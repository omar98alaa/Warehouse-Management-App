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
    public partial class TransfersForm: Form
    {
        //
        //  Members
        //
        AppDbContext appDbContext = new AppDbContext();
        List<Warehouse> warehouses;
        List<Contact> suppliers;
        List<WarehouseProduct> warehouseProducts;
        List<Item> addedProducts = new List<Item>();
        BindingSource gridSource = new BindingSource();


        //
        //  Constructors
        //
        public TransfersForm()
        {
            InitializeComponent();

            // Disable selecting products until source warehouse is selected
            ProductsComboBox.Enabled = false;

            ProductsDataGridView.DataSource = gridSource;

            // Load all data
            LoadData();

            // Bind added products list to grid
            addedProducts = new List<Item>();
            gridSource.DataSource = addedProducts;

            // Hide ID column
            ProductsDataGridView.Columns["ID"].Visible = false;
        }


        //
        //  Methods
        //
        void LoadWarehouses()
        {
            if (appDbContext != null)
            {
                warehouses = (from W in appDbContext.Warehouses orderby W.Name select W).Include("WarehouseProducts.Product").ToList();

                SourceWarehousesComboBox.DataSource = (from W in warehouses select W.Name).ToList();
                DestinationWarehousesComboBox.DataSource = (from W in warehouses select W.Name).ToList();
            }
        }

        void LoadSuppliers()
        {
            if (appDbContext != null)
            {
                suppliers = (from S in appDbContext.Contacts where S.Type == ContactType.Supplier orderby S.Email select S).ToList();

                SuppliersComboBox.DataSource = (from S in suppliers select S.Email).ToList();
            }
        }

        void LoadData()
        {
            LoadWarehouses();
            LoadSuppliers();
            ClearInputFields();
        }

        void ClearInputFields()
        {
            SourceWarehousesComboBox.SelectedIndex = -1;
            SourceWarehousesComboBox.ResetText();

            DestinationWarehousesComboBox.SelectedIndex = -1;
            DestinationWarehousesComboBox.ResetText();

            SuppliersComboBox.SelectedIndex = -1;
            SuppliersComboBox.ResetText();

            ProductsComboBox.SelectedIndex = -1;
            ProductsComboBox.ResetText();

            ProductQuantityNumeric.Value = ProductQuantityNumeric.Minimum;

            if (addedProducts.Count > 0)
            {
                ClearAddedProducts();
            }
        }

        void ClearAddedProducts()
        {
            // Revert to original product quantity values when clearing added products
            var Changeditems = appDbContext.ChangeTracker.Entries<WarehouseProduct>();

            foreach (var item in Changeditems)
            {
                item.CurrentValues.SetValues(item.OriginalValues);
            }

            addedProducts = new List<Item>();
            gridSource.DataSource = addedProducts;

        }


        //
        //  Event handlers
        //
        private void AddProductButton_Click(object sender, EventArgs e)
        {
            if (ProductsComboBox.SelectedIndex != -1 && ProductQuantityNumeric.Value > 0)
            {
                var idx = ProductsComboBox.SelectedIndex;
                var warehouseProduct = warehouseProducts[idx];
                var productionDate = warehouseProduct.ProductionDate;

                // Check if entry already exists in added products
                var existingItem = (from I in addedProducts where I.ID == idx select I).FirstOrDefault();

                if (existingItem != null)
                {
                    MessageBox.Show("Product with the same name and production date already added.");
                }
                else
                {
                    // Add new entry to added products
                    var item = new Item(
                        idx,
                        warehouseProduct.ProductCode,
                        warehouseProduct.Product.Name,
                        productionDate,
                        warehouseProduct.Product.ExpiryPeriod,
                        (int)ProductQuantityNumeric.Value
                        );

                    gridSource.Add(item);

                    // Subtract the warehouse product quantity
                    warehouseProduct.Quantity -= item.Quantity;

                    // Mark warehouse product for update
                    appDbContext.WarehouseProducts.Update(warehouseProduct);

                    // Refresh the displayed quantity
                    ProductsComboBox.SelectedIndex = -1;
                    ProductsComboBox.SelectedIndex = idx;
                }
            }
        }

        private void RemoveProductButton_Click(object sender, EventArgs e)
        {
            if (ProductsDataGridView.SelectedRows.Count == 1)
            {
                // Get the selected row
                var row = ProductsDataGridView.SelectedRows[0];

                // Get bound item
                var item = (Item)row.DataBoundItem;

                // Get corresponding warehouse product
                var warehouseProduct = warehouseProducts[item.ID];

                // Add back the quantity
                warehouseProduct.Quantity += item.Quantity;

                // Mark warehouse product for update
                appDbContext.WarehouseProducts.Update(warehouseProduct);

                // Remove row for grid view
                ProductsDataGridView.Rows.Remove(row);

                // Refresh displayed quatity
                var idx = ProductsComboBox.SelectedIndex;
                ProductsComboBox.SelectedIndex = -1;
                ProductsComboBox.SelectedIndex = idx;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (SourceWarehousesComboBox.SelectedIndex == -1)
                {
                    throw new ApplicationException("Warehouse is not selected");
                }
                else if (DestinationWarehousesComboBox.SelectedIndex == -1)
                {
                    throw new ApplicationException("Warehouse is not selected");
                }
                else if (DestinationWarehousesComboBox.SelectedIndex == SourceWarehousesComboBox.SelectedIndex)
                {
                    throw new ApplicationException("Source and Destination cannot be the same");
                }
                else if (SuppliersComboBox.SelectedIndex == -1)
                {
                    throw new ApplicationException("Supplier is not selected");
                }
                else if (addedProducts.Count == 0)
                {
                    throw new ApplicationException("No products were added");
                }

                // Create new transfer and set properties
                var transfer = new Transfer();

                Warehouse sourceWarehouse = warehouses[SourceWarehousesComboBox.SelectedIndex];
                Warehouse destinationWarehouse = warehouses[DestinationWarehousesComboBox.SelectedIndex];
                Contact supplier = suppliers[SuppliersComboBox.SelectedIndex];

                transfer.SourceWarehouseID = sourceWarehouse.ID;
                transfer.DestinationWarehouse = destinationWarehouse;
                transfer.ContactID = supplier.ID;
                transfer.IssueDate = DateTime.Now.Date;
                transfer.TransferedProducts = new List<TransferedProduct>();

                // Populate transfered products for added products list
                foreach (var P in addedProducts)
                {
                    var transferedProduct = new TransferedProduct()
                    {
                        Quantity = P.Quantity,
                        ProductCode = P.Code,
                        ProductionDate = P.Production_Date
                    };

                    transfer.TransferedProducts.Add(transferedProduct);

                    // Check if matching warehouse product already exists in destination warehouse
                    var existingWarehouseProduct = (
                        from WP in destinationWarehouse.WarehouseProducts
                        where WP.ProductCode == P.Code && WP.ProductionDate == P.Production_Date && WP.AddedDate == DateTime.Now.Date
                        select WP
                        ).FirstOrDefault();

                    if (existingWarehouseProduct != null)
                    {
                        // Add to its quantity
                        existingWarehouseProduct.Quantity += P.Quantity;
                    }
                    else
                    {
                        // Add new warehouse product
                        var warehouseProduct = new WarehouseProduct()
                        {
                            ProductCode = P.Code,
                            ProductionDate = P.Production_Date,
                            Quantity = P.Quantity,
                            AddedDate = DateTime.Now.Date
                        };

                        destinationWarehouse.WarehouseProducts.Add(warehouseProduct);
                    }

                    appDbContext.Warehouses.Update(destinationWarehouse);
                }

                // Remove 0 quatity products in source
                var removedProducts = (from WP in sourceWarehouse.WarehouseProducts where WP.Quantity == 0 select WP).ToList();

                appDbContext.WarehouseProducts.RemoveRange(removedProducts);

                appDbContext.Transfers.Add(transfer);

                appDbContext.SaveChanges();

                MessageBox.Show("Transfer saved successfully. Warehouse storage updated");

                // Reload data
                LoadData();
            }
            catch (ApplicationException E)
            {
                MessageBox.Show(E.Message);
            }
            catch (Exception E)
            {
                MessageBox.Show("Failed to save transfer");
                //MessageBox.Show(E.Message);
                //MessageBox.Show(E.InnerException?.Message);
            }
        }

        private void SourceWarehousesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Properly clear added products
            if (addedProducts.Count > 0)
            {
                ClearAddedProducts();
            }

            if (SourceWarehousesComboBox.SelectedIndex != -1)
            {
                // Get and display available products in the selected source warehouse
                var warehouse = warehouses[SourceWarehousesComboBox.SelectedIndex];

                warehouseProducts = (from WP in warehouse.WarehouseProducts orderby WP.Product.Name, WP.ProductionDate, WP.AddedDate select WP).ToList();

                ProductsComboBox.DataSource = (
                    from WP in warehouseProducts 
                    select $"{WP.Product.Name}, Prod:{WP.ProductionDate.ToString("dd-MM-yyyy")}, Added:{WP.AddedDate.ToString("dd-MM-yyyy")}"
                    ).ToList();

                // Enable product selection
                ProductsComboBox.Enabled = true;
            }
            else
            {
                // Disable product selection if no source warehouse selected
                ProductsComboBox.Enabled = false;
            }
        }

        private void ProductsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProductsComboBox.SelectedIndex != -1)
            {
                var warehouseProduct = warehouseProducts[ProductsComboBox.SelectedIndex];
                
                // Set max quantity to available quantity
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

