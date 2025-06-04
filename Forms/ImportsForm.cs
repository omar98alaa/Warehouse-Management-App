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
    public partial class ImportsForm : Form
    {
        //
        //  Members
        //
        AppDbContext appDbContext = new AppDbContext();
        List<Warehouse> warehouses;
        List<Contact> suppliers;
        List<Product> products;
        List<Item> addedProducts = new List<Item>();
        BindingSource gridSource = new BindingSource();


        //
        //  Constructors
        //
        public ImportsForm()
        {
            InitializeComponent();

            // Set date picker max date to current date
            ProductionDateTimePicker.MaxDate = DateTime.Now.Date;

            // Set grid view data source to a binding source
            gridSource.DataSource = addedProducts;
            ProductsDataGridView.DataSource = gridSource;

            // Load all data
            LoadData();

            // Hide the ID column in grid view
            ProductsDataGridView.Columns["ID"].Visible = false;
        }


        //
        //  Methods
        //
        void LoadWarehouses()
        {
            // Load all warehouses
            if (appDbContext != null)
            {
                warehouses = (from W in appDbContext.Warehouses orderby W.Name select W).Include("WarehouseProducts").ToList();

                WarehousesComboBox.DataSource = (from W in warehouses select W.Name).ToList();
            }
        }

        void LoadSuppliers()
        {
            // Load all suppliers
            if (appDbContext != null)
            {
                suppliers = (from C in appDbContext.Contacts where C.Type == ContactType.Supplier orderby C.Email select C).ToList();

                SuppliersComboBox.DataSource = (from S in suppliers select S.Email).ToList();
            }
        }

        void LoadProducts()
        {
            // Load all registered products
            if (appDbContext != null)
            {
                products = (from P in appDbContext.Products orderby P.Name select P).ToList();

                ProductsComboBox.DataSource = (from P in products select P.Name).ToList();
            }
        }

        void LoadData()
        {
            LoadWarehouses();
            LoadSuppliers();
            LoadProducts();
            ClearInputFields();
        }

        void ClearInputFields()
        {
            WarehousesComboBox.SelectedIndex = -1;
            WarehousesComboBox.ResetText();

            SuppliersComboBox.SelectedIndex = -1;
            SuppliersComboBox.ResetText();

            ProductsComboBox.SelectedIndex = -1;
            ProductsComboBox.ResetText();

            ProductionDateTimePicker.Value = ProductionDateTimePicker.MaxDate;
            ProductQuantityNumeric.Value = ProductQuantityNumeric.Minimum;

            if (addedProducts.Count > 0)
            {
                ClearAddedProducts();
            }
        }

        void ClearAddedProducts()
        {
            // Set added products list to a new list and discard the old one
            addedProducts = new List<Item>();
            gridSource.DataSource = addedProducts;
        }


        //
        //  Event handlers
        //
        private void AddProductButton_Click(object sender, EventArgs e)
        {
            if (ProductsComboBox.SelectedIndex != -1)
            {
                var idx = ProductsComboBox.SelectedIndex;
                var product = products[idx];
                var productionDate = ProductionDateTimePicker.Value.Date;

                // Check if the product with the same production date is already in the added list
                var existingItem = (from I in addedProducts where I.Name == product.Name && I.Production_Date == productionDate select I).FirstOrDefault();

                if (existingItem != null)
                {
                    MessageBox.Show("Product with the same name and production date already added.");
                }
                else
                {
                    // Create a new Item and add it to the added products list
                    var item = new Item(
                        idx,
                        product.Code,
                        product.Name,
                        productionDate,
                        product.ExpiryPeriod,
                        (int)ProductQuantityNumeric.Value
                        );

                    gridSource.Add(item);
                }
            }
        }

        private void RemoveProductButton_Click(object sender, EventArgs e)
        {
            
            if (ProductsDataGridView.SelectedRows.Count == 1)
            {
                // Get the selected row in the grid view and remove it.
                ProductsDataGridView.Rows.Remove(ProductsDataGridView.SelectedRows[0]);
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
                else if (SuppliersComboBox.SelectedIndex == -1)
                {
                    throw new ApplicationException("Supplier is not selected");
                }
                else if (addedProducts.Count == 0)
                {
                    throw new ApplicationException("No products were added");
                }

                // Create new import and set its properties
                var import = new Import();

                Warehouse warehouse = warehouses[WarehousesComboBox.SelectedIndex];
                Contact supplier = suppliers[SuppliersComboBox.SelectedIndex];

                import.WarehouseID = warehouse.ID;
                import.ContactID = supplier.ID;
                import.IssueDate = DateTime.Now.Date;
                import.ImportedProducts = new List<ImportedProduct>();

                // Populate the imported Products with items form the added 
                foreach (var P in addedProducts)
                {
                    var importedProduct = new ImportedProduct()
                    {
                        ProductionDate = P.Production_Date,
                        Quantity = P.Quantity,
                        ProductCode = P.Code,
                    };

                    import.ImportedProducts.Add(importedProduct);

                    // Check if the product with the same production date and added date exists in the warehouse
                    var existingWarehouseProduct = (
                        from WP in warehouse.WarehouseProducts
                        where WP.ProductCode == P.Code && WP.ProductionDate == P.Production_Date && WP.AddedDate == DateTime.Now.Date
                        select WP
                        ).FirstOrDefault();

                    if (existingWarehouseProduct != null)
                    {
                        // If exists increment quantity
                        existingWarehouseProduct.Quantity += P.Quantity;
                    }
                    else
                    {
                        // Else add the new warehouse product
                        var warehouseProduct = new WarehouseProduct()
                        {
                            ProductCode = P.Code,
                            ProductionDate = P.Production_Date,
                            Quantity = P.Quantity,
                            AddedDate = DateTime.Now.Date
                        };

                        warehouse.WarehouseProducts.Add(warehouseProduct);
                    }

                    appDbContext.Warehouses.Update(warehouse);
                }

                appDbContext.Imports.Add(import);

                appDbContext.SaveChanges();

                MessageBox.Show("Import saved successfully. Warehouse storage updated");

                // Reload data
                LoadData();
            }
            catch (ApplicationException E)
            {
                MessageBox.Show(E.Message);
            }
            catch (Exception E)
            {
                MessageBox.Show("Failed to save import");
                //MessageBox.Show(E.Message);
                //MessageBox.Show(E.InnerException?.Message);
            }
        }
    }

    class Item
    {
        public int ID { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public DateTime Production_Date { get; set; }
        public int Expiry_Period { get; set; }
        public int Quantity { get; set; }

        public Item(int Id, int code, string name, DateTime production_Date, int expiry_Period, int quantity)
        {
            ID = Id;
            Code = code;
            Name = name;
            Production_Date = production_Date;
            Expiry_Period = expiry_Period;
            Quantity = quantity;
        }
    }
}
