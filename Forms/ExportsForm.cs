using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse_Management_App.Entities;

namespace Warehouse_Management_App.Forms
{
    public partial class ExportsForm : Form
    {
        //
        //  Members
        //
        AppDbContext m_appDbContext = new AppDbContext();
        List<Warehouse> m_warehouses;
        List<Contact> m_clients;
        List<WarehouseProduct> m_warehouseProducts;
        List<Item> m_addedProducts = new List<Item>();
        BindingSource m_gridSource = new BindingSource();


        //
        //  Constructors
        //
        public ExportsForm()
        {
            InitializeComponent();

            // Disable product selection until warehouse is selected
            ProductsComboBox.Enabled = false;

            // Set Products grid data source to a binding source for easier access
            ProductsDataGridView.DataSource = m_gridSource;

            // Load all required data
            LoadData();

            // Bind added products list to binding source data source
            m_addedProducts = new List<Item>();
            m_gridSource.DataSource = m_addedProducts;
            
            // Hide ID column
            ProductsDataGridView.Columns["ID"].Visible = false;
        }


        //
        //  Methods
        //
        void LoadWarehouses()
        {
            // Load all available warehouses
            if (m_appDbContext != null)
            {
                m_warehouses = (from W in m_appDbContext.Warehouses orderby W.Name select W).Include("WarehouseProducts.Product").ToList();

                WarehousesComboBox.DataSource = (from W in m_warehouses select W.Name).ToList();
            }
        }

        void LoadClients()
        {
            // Load all available clients
            if (m_appDbContext != null)
            {
                m_clients = (from C in m_appDbContext.Contacts where C.Type == ContactType.Client orderby C.Email select C).ToList();

                ClientsComboBox.DataSource = (from S in m_clients select S.Email).ToList();
            }
        }

        void LoadData()
        {
            LoadWarehouses();
            LoadClients();
            ClearInputFields();
        }

        void ClearInputFields()
        {
            WarehousesComboBox.SelectedIndex = -1;
            WarehousesComboBox.ResetText();

            ClientsComboBox.SelectedIndex = -1;
            ClientsComboBox.ResetText();

            ProductsComboBox.SelectedIndex = -1;
            ProductsComboBox.ResetText();

            ProductQuantityNumeric.Value = ProductQuantityNumeric.Minimum;

            if (m_addedProducts.Count > 0)
            {
                ClearAddedProducts();
            }
        }

        void ClearAddedProducts()
        {
            // Get the tracked items
            var Changeditems = m_appDbContext.ChangeTracker.Entries<WarehouseProduct>();

            foreach(var item in Changeditems)
            {
                // Reset values to original values
                item.CurrentValues.SetValues(item.OriginalValues);
            }

            // Clear added products list
            m_addedProducts = new List<Item>();
            m_gridSource.DataSource = m_addedProducts;
        }


        //
        //  Event handlers
        //
        private void AddProductButton_Click(object sender, EventArgs e)
        {
            if (ProductsComboBox.SelectedIndex != -1 && ProductQuantityNumeric.Value > 0)
            {
                var idx = ProductsComboBox.SelectedIndex;
                var warehouseProduct = m_warehouseProducts[idx];
                var productionDate = warehouseProduct.ProductionDate;

                // Check if item is already in added products
                var existingItem = (from I in m_addedProducts where I.ID == idx select I).FirstOrDefault();

                if (existingItem != null)
                {
                    MessageBox.Show("Product with the same name and production date already added.");
                }
                else
                {
                    // Create new item and add it to added products
                    var item = new Item(
                        idx,
                        warehouseProduct.ProductCode,
                        warehouseProduct.Product.Name,
                        productionDate,
                        warehouseProduct.Product.ExpiryPeriod,
                        (int)ProductQuantityNumeric.Value
                        );

                    m_gridSource.Add(item);

                    // Sub quantity from the warehouse product
                    warehouseProduct.Quantity -= item.Quantity;

                    // Mark the warehouse product for update
                    m_appDbContext.WarehouseProducts.Update(warehouseProduct);

                    // Refresh the selected product to display the modified quantity
                    ProductsComboBox.SelectedIndex = -1;
                    ProductsComboBox.SelectedIndex = idx;
                }
            }
        }

        private void RemoveProductButton_Click(object sender, EventArgs e)
        {
            if (ProductsDataGridView.SelectedRows.Count == 1)
            {
                // Get the selected row in grid
                var row = ProductsDataGridView.SelectedRows[0];

                // Get the corresponding bound item
                var item = (Item)row.DataBoundItem;

                // Get the corresponding warehouse product
                var warehouseProduct = m_warehouseProducts[item.ID];

                // Add back the quantity
                warehouseProduct.Quantity += item.Quantity;

                // Mark the warehouse product for update with the current quantity
                m_appDbContext.WarehouseProducts.Update(warehouseProduct);

                // Remove the row from grid view
                ProductsDataGridView.Rows.Remove(row);

                // Refresh the selected product to display the modified quantity
                var idx = ProductsComboBox.SelectedIndex;
                ProductsComboBox.SelectedIndex = -1;
                ProductsComboBox.SelectedIndex = idx;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input fields
                if (WarehousesComboBox.SelectedIndex == -1)
                {
                    throw new ApplicationException("Warehouse is not selected");
                }
                else if (ClientsComboBox.SelectedIndex == -1)
                {
                    throw new ApplicationException("Client is not selected");
                }
                else if (m_addedProducts.Count == 0)
                {
                    throw new ApplicationException("No products were added");
                }

                var export = new Export();

                Warehouse warehouse = m_warehouses[WarehousesComboBox.SelectedIndex];
                Contact client = m_clients[ClientsComboBox.SelectedIndex];

                // Set the new export properties
                export.WarehouseID = warehouse.ID;
                export.ContactID = client.ID;
                export.IssueDate = DateTime.Now.Date;
                export.ExportedProducts = new List<ExportedProduct>();

                // Populate the exported products
                foreach (var P in m_addedProducts)
                {
                    var exportedProduct = new ExportedProduct()
                    {
                        Quantity = P.Quantity,
                        ProductCode = P.Code,
                    };

                    export.ExportedProducts.Add(exportedProduct);
                }

                // Remove warehouse products with quantity = 0
                var removedProducts = (from WP in warehouse.WarehouseProducts where WP.Quantity == 0 select WP).ToList();

                m_appDbContext.WarehouseProducts.RemoveRange(removedProducts);

                // Add the new export
                m_appDbContext.Exports.Add(export);

                // Save all changes to DB
                m_appDbContext.SaveChanges();

                MessageBox.Show("Export saved successfully. Warehouse storage updated");

                // Reload data
                LoadData();
            }
            catch (ApplicationException E)
            {
                MessageBox.Show(E.Message);
            }
            catch (Exception E)
            {
                MessageBox.Show("Failed to save export");
                //MessageBox.Show(E.Message);
                //MessageBox.Show(E.InnerException?.Message);
            }
        }

        private void WarehousesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_addedProducts.Count > 0)
            {
                // Clear added products properly when selected warehouse changes
                ClearAddedProducts();
            }

            if (WarehousesComboBox.SelectedIndex != -1)
            {
                var warehouse = m_warehouses[WarehousesComboBox.SelectedIndex];

                // Load warehouse products
                m_warehouseProducts = (from WP in warehouse.WarehouseProducts orderby WP.Product.Name, WP.ProductionDate, WP.AddedDate select WP).ToList();

                // Load and Display available products as name, production date, added date
                ProductsComboBox.DataSource = (
                    from WP in m_warehouseProducts
                    select $"{WP.Product.Name}, Prod:{WP.ProductionDate.ToString("dd-MM-yyyy")}, Added:{WP.AddedDate.ToString("dd-MM-yyyy")}"
                    ).ToList();

                // Enable selecting a product
                ProductsComboBox.Enabled = true;
            }
            else
            {
                // Disable selecting a product if no warehouse is selected
                ProductsComboBox.Enabled = false;
            }
        }

        private void ProductsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProductsComboBox.SelectedIndex != -1)
            {
                var warehouseProduct = m_warehouseProducts[ProductsComboBox.SelectedIndex];

                // Update maximum quantity displayed to match available product quantity
                ProductQuantityNumeric.Maximum = warehouseProduct.Quantity;

                ProductQuantityNumeric.Value = ProductQuantityNumeric.Maximum;
            }
            else
            {
                // Set quantity to 0 if no product is selected
                ProductsComboBox.ResetText();
                ProductQuantityNumeric.Value = 0;
            }
        }
    }
}
