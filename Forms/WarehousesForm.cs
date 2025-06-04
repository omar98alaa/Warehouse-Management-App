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
    public partial class WarehousesForm : Form
    {
        //
        //  Fields
        //
        AppDbContext AppDbContext = new AppDbContext();
        List<Warehouse> Warehouses;


        //
        //  Constructors
        //
        public WarehousesForm()
        {
            InitializeComponent();

            // Disable warehouse selection if adding a new warehouse
            WarehouseComboBox.Enabled = !AddRadioButton.Checked;
        }


        //
        //  Mehtods
        //
        void LoadWarehousesList()
        {
            AppDbContext = new AppDbContext();

            Warehouses = (from W in AppDbContext.Warehouses orderby W.Name select W).ToList();

            WarehouseComboBox.DataSource = (from W in Warehouses select W.Name).ToList();
            WarehouseComboBox.SelectedIndex = -1;
            WarehouseComboBox.ResetText();
        }

        void ClearInputFields()
        {
            WarehouseNameTextBox.Text = "";
            ManagerNameTextBox.Text = "";
            CityTextBox.Text = "";
            StreetTextBox.Text = "";
        }

        //
        //  Event handlers
        //
        private void AddRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            WarehouseComboBox.Enabled = !AddRadioButton.Checked;

            if (AddRadioButton.Checked)
            {
                // Clear input fields if adding a new warehouse
                ClearInputFields();
            }else if(Warehouses == null)
            {
                // Load warehouse list if modifying an existing warehouse
                LoadWarehousesList();
            }
        }

        private void WarehouseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WarehouseComboBox.SelectedIndex != -1)
            {
                // Populate the input fields with the selected warehouse info
                int idx = WarehouseComboBox.SelectedIndex;

                WarehouseNameTextBox.Text = Warehouses[idx].Name;
                ManagerNameTextBox.Text = Warehouses[idx].Manager;
                CityTextBox.Text = Warehouses[idx].City;
                StreetTextBox.Text = Warehouses[idx].Street;
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
                if(WarehouseNameTextBox.Text == "" || ManagerNameTextBox.Text == "" || CityTextBox.Text == "" || StreetTextBox.Text == "")
                {
                    throw new ApplicationException("Invalid Entries");
                }

                Warehouse warehouse;

                if (AddRadioButton.Checked)
                {
                    warehouse = new Warehouse();
                }
                else
                {
                    var idx = WarehouseComboBox.SelectedIndex;
                    warehouse = Warehouses[idx];
                }

                // Set the warehouse properties
                warehouse.Name = WarehouseNameTextBox.Text;
                warehouse.Manager = ManagerNameTextBox.Text;
                warehouse.City = CityTextBox.Text;
                warehouse.Street = StreetTextBox.Text;

                AppDbContext.Warehouses.Update(warehouse);

                AppDbContext.SaveChanges();

                MessageBox.Show("Warehouse saved successfully");

                // Reload warehouse list
                LoadWarehousesList();
            }
            catch (ApplicationException E)
            {
                MessageBox.Show(E.Message);
            }
            catch
            {
                MessageBox.Show("Failed to save warehouse");
            }
        }
    }
}
