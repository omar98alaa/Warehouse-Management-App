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
    public partial class StockReportForm : Form
    {
        //
        //  Fields
        //
        AppDbContext appDbContext = new AppDbContext();
        List<Warehouse> warehouses;
        Warehouse warehouse;
        DateTime fromDate;
        DateTime toDate;


        //
        //  Constructors
        //
        public StockReportForm()
        {
            InitializeComponent();

            // Get available warehouses
            LoadWarehouses();
        }


        //
        //  Methods
        //
        void LoadWarehouses()
        {
            warehouses = (from W in appDbContext.Warehouses orderby W.Name select W).ToList();

            WarehouseComboBox.DataSource = (from W in warehouses select W.Name).ToList();
        }

        void UpdateStockDisplay()
        {
            if (warehouse != null)
            {
                // Get all the stock for the selected warehouse while displaying days in storage and remaining days until expired
                var warehouseProducts = (
                    from WP in appDbContext.WarehouseProducts
                    where WP.WarehouseID == warehouse.ID
                    orderby WP.Product.Name, WP.ProductionDate, WP.AddedDate
                    select new
                    {
                        Code = WP.Product.Code,
                        Product_Name = WP.Product.Name,
                        Production_Date = WP.ProductionDate,
                        Expiry_Date = WP.ProductionDate.AddDays(WP.Product.ExpiryPeriod).Date,
                        Remaining_Days = (WP.ProductionDate.AddDays(WP.Product.ExpiryPeriod) - DateTime.Now.Date).Days,
                        Date_Added = WP.AddedDate,
                        Days_In_Storage = (DateTime.Now.Date - WP.AddedDate).Days,
                        Quantity = WP.Quantity
                    }).ToList();

                if (InStorageRadioButton.Checked)
                {
                    // Filter by days in storage
                    StockDataGridView.DataSource = (from P in warehouseProducts where P.Days_In_Storage >= DaysNumeric.Value select P).ToList();
                }
                else
                {
                    // Filter by days remaining until expired
                    StockDataGridView.DataSource = (from P in warehouseProducts where P.Remaining_Days <= DaysNumeric.Value select P).ToList();
                }
            }
        }


        //
        //  Event handlers
        //
        private void WarehouseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WarehouseComboBox.SelectedIndex != -1)
            {
                // Update displayed stock for the selected warehouses
                warehouse = warehouses[WarehouseComboBox.SelectedIndex];

                UpdateStockDisplay();
            }
            else
            {
                warehouse = null;
            }
        }

        private void DaysNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (warehouse != null)
            {
                // Update displayed stock for the filter value
                UpdateStockDisplay();
            }
        }

        private void InStorageRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (warehouse != null)
            {
                // Update displayed stock for the filter chosen
                UpdateStockDisplay();
            }
        }
    }
}
