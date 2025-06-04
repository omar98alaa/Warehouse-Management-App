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
    public partial class ProductsForm : Form
    {
        //
        //  Fields
        //
        AppDbContext AppDbContext = new AppDbContext();
        List<Product> Products;
        List<Unit> Units;


        //
        //  Constructors
        //
        public ProductsForm()
        {
            InitializeComponent();

            LoadUnits();

            // Disable product selection if adding a new one
            ProductComboBox.Enabled = !AddRadioButton.Checked;

            ExpiryPeriodNumeric.Minimum = 1;
            ExpiryPeriodNumeric.Maximum = 9999;
        }


        //
        //  Mehtods
        //
        void LoadProductsList()
        {
            // Get all registered products
            AppDbContext = new AppDbContext();

            Products = (from P in AppDbContext.Products orderby P.Name select P).Include("ProductUnits").ToList();

            ProductComboBox.DataSource = (from P in Products select P.Name).ToList();
            ProductComboBox.SelectedIndex = -1;
            ProductComboBox.ResetText();
        }

        void LoadUnits()
        {
            // Get all the available product units
            if (AppDbContext != null)
            {
                Units = (from U in AppDbContext.Units orderby U.Name select U).ToList();
                
                UnitsCheckedListBox.Items.Clear();

                foreach (var U in Units)
                {
                    UnitsCheckedListBox.Items.Add(U.Name);
                }
            }
        }

        void ClearInputFields()
        {
            ProductNameTextBox.Text = "";
            ProductCodeTextBox.Text = "";
            ExpiryPeriodNumeric.Value = ExpiryPeriodNumeric.Minimum;

            foreach(int idx in UnitsCheckedListBox.CheckedIndices)
            {
                // Clear checked units
                UnitsCheckedListBox.SetItemCheckState(idx, CheckState.Unchecked);
            }
        }


        //
        //  Event handlers
        //
        private void AddRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Disable product selection when adding a new product
            ProductComboBox.Enabled = !AddRadioButton.Checked;

            // Disable product code change when modifying a product
            ProductCodeTextBox.Enabled = AddRadioButton.Checked;

            if (AddRadioButton.Checked)
            {
                // Clear input fields when adding
                ClearInputFields();
            }
            else if (Products == null)
            {
                // Load products list on modify
                LoadProductsList();
            }
        }

        private void ProductComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProductComboBox.SelectedIndex != -1)
            {
                int idx = ProductComboBox.SelectedIndex;
                var product = Products[idx];

                // Set input fields with selected product info
                ProductNameTextBox.Text = product.Name;
                ProductCodeTextBox.Text = product.Code.ToString();
                ExpiryPeriodNumeric.Value = product.ExpiryPeriod;

                // Load and check the selected product units
                var productUnits = (from U in product.ProductUnits select U.UnitName).ToHashSet();
                var checkItems = UnitsCheckedListBox.Items;

                for(int i=0; i < checkItems.Count; i++)
                {
                    if (productUnits.Contains(checkItems[i]))
                    {
                        UnitsCheckedListBox.SetItemCheckState(i, CheckState.Checked);
                    }
                    else
                    {
                        UnitsCheckedListBox.SetItemCheckState(i, CheckState.Unchecked);
                    }
                }
            }
            else
            {
                ClearInputFields();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (ProductNameTextBox.Text == "" || ProductCodeTextBox.Text == "")
                {
                    throw new ApplicationException("Invalid entries");
                }else if (UnitsCheckedListBox.CheckedItems.Count == 0)
                {
                    throw new ApplicationException("At least one product unit must be selected");
                }

                Product product;

                if (AddRadioButton.Checked)
                {
                    product = new Product();
                    product.ProductUnits = new List<ProductUnit>();
                }
                else
                {
                    var idx = ProductComboBox.SelectedIndex;
                    product = Products[idx];
                }

                // Set the product properties
                product.Name = ProductNameTextBox.Text;
                product.Code = Convert.ToInt32(ProductCodeTextBox.Text);
                product.ExpiryPeriod = Convert.ToInt32(ExpiryPeriodNumeric.Value);

                // Add the product units
                var productUnits = (from U in product.ProductUnits select U.UnitName).ToHashSet();
                foreach (string unitName in UnitsCheckedListBox.CheckedItems)
                {
                    if (!productUnits.Contains(unitName))
                    {
                        product.ProductUnits.Add(new ProductUnit() { ProductCode = product.Code, UnitName = unitName });
                    }
                }


                if (AddRadioButton.Checked)
                {
                    // Check if product already exists before adding
                    var existingProduct = (from P in AppDbContext.Products where P.Code == product.Code select P).FirstOrDefault();
                    if (existingProduct != null)
                    {
                        throw new ApplicationException("Duplicate Product Code is not allowed");
                    }

                    AppDbContext.Products.Add(product);
                }
                else
                {
                    // Update product
                    AppDbContext.Products.Update(product);
                }

                AppDbContext.SaveChanges();

                MessageBox.Show("Product saved successfully");

                // Reload products
                LoadProductsList();
            }
            catch (ApplicationException E)
            {
                MessageBox.Show(E.Message);
            }
            catch(Exception E)
            {
                MessageBox.Show("Failed to save product");
                //MessageBox.Show(E.Message);
                //MessageBox.Show(E.InnerException?.Message);
            }
        }

        private void ProductCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numbers and backspace
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void AddUnitButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (AddUnitTextBox.Text != "")
                {
                    // Add new unit
                    var UnitName = AddUnitTextBox.Text.ToLowerInvariant();
                    var existingUnit = (from U in Units where U.Name == UnitName select U).FirstOrDefault();

                    if (existingUnit != null)
                    {
                        throw new ApplicationException("Unit already exists");
                    }

                    var Unit = new Unit();
                    Unit.Name = UnitName;

                    AppDbContext.Units.Add(Unit);

                    AppDbContext.SaveChanges();

                    MessageBox.Show("New unit added successfully");

                    AddUnitTextBox.Text = "";

                    LoadUnits();
                }
            }catch(ApplicationException E)
            {
                MessageBox.Show(E.Message);
            }
            catch
            {
                MessageBox.Show("Failed to add new unit");
            }
        }
    }
}
