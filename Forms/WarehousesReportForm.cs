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
    public partial class WarehousesReportForm : Form
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
        public WarehousesReportForm()
        {
            InitializeComponent();

            // Set to date to current date
            FromDateTimePicker.MaxDate = DateTime.Now.Date;
            ToDateTimePicker.MaxDate = DateTime.Now.Date;

            // Set from date 30 days before
            FromDateTimePicker.Value = DateTime.Now.AddDays(-30).Date;

            // Clear info labels
            WarehouseNameLabel.Text = "";
            ManagerNameLabel.Text = "";
            WarehouseAddressLabel.Text = "";

            // Add report types
            ReportsComboBox.Items.AddRange(["Stock", "Imports", "Exports", "Transfers"]);

            // Load all warehouses
            LoadWarehouses();
        }


        //
        //  Methods
        //
        void LoadWarehouses()
        {
            warehouses = (from W in appDbContext.Warehouses orderby W.Name select W).Include("WarehouseProducts.Product").ToList();

            WarehouseComboBox.DataSource = (from W in warehouses select W.Name).ToList();
        }

        void UpdateInfo()
        {
            if (warehouse != null)
            {
                WarehouseNameLabel.Text = warehouse.Name;
                ManagerNameLabel.Text = warehouse.Manager;
                WarehouseAddressLabel.Text = $"{warehouse.Street}, {warehouse.City}";
            }
        }

        void UpdateStockDisplay()
        {
            if (warehouse != null)
            {
                // Get all stock for the selected warehouse
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
                        Date_Added = WP.AddedDate,
                        Quantity = WP.Quantity
                    }).ToList();

                ReportDataGridView.DataSource = warehouseProducts;
            }
        }

        void UpdateImportsDisplay()
        {
            if (warehouse != null)
            {
                // Get all imports for the selected warehouse in the selected period
                var imports = (
                    from I in appDbContext.Imports
                    where I.WarehouseID == warehouse.ID && fromDate.Date <= I.IssueDate.Date && I.IssueDate.Date <= toDate.Date
                    orderby I.IssueDate descending
                    select new
                    {
                        Date = I.IssueDate,
                        Supplier = I.Contact.Email,
                        Imported_Products = I.ImportedProducts.Count()
                    }
                    ).ToList();

                ReportDataGridView.DataSource = imports;
            }
        }

        void UpdateExportsDisplay()
        {
            if (warehouse != null)
            {
                // Get all exports for the selected warehouse in the selected period
                var exports = (
                    from I in appDbContext.Exports
                    where I.WarehouseID == warehouse.ID && fromDate.Date <= I.IssueDate.Date && I.IssueDate.Date <= toDate.Date
                    orderby I.IssueDate descending
                    select new
                    {
                        Date = I.IssueDate,
                        Client = I.Contact.Email,
                        Exported_Products = I.ExportedProducts.Count()
                    }
                    ).ToList();

                ReportDataGridView.DataSource = exports;
            }
        }

        void UpdateTransfersDisplay()
        {
            if (warehouse != null)
            {
                // Get all transfers for the selected warehouse in the selected period
                var transfers = (
                    from I in appDbContext.Transfers
                    where (I.DestinationWarehouseID == warehouse.ID || I.SourceWarehouseID == warehouse.ID) &&
                        fromDate.Date <= I.IssueDate.Date &&
                        I.IssueDate.Date <= toDate.Date
                    orderby I.IssueDate descending
                    select new
                    {
                        Date = I.IssueDate,
                        Supplier = I.Contact.Email,
                        Source = I.SourceWarehouse.Name,
                        Destination = I.DestinationWarehouse.Name,
                        Transfered_Products = I.TransferedProducts.Count()
                    }
                    ).ToList();

                ReportDataGridView.DataSource = transfers;
            }
        }

        void RefreshReportDisplay()
        {
            // Change selected index to reload data
            var idx = ReportsComboBox.SelectedIndex;
            ReportsComboBox.SelectedIndex = -1;
            ReportsComboBox.SelectedIndex = idx;
        }


        //
        //  Event handlers
        //
        private void WarehouseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WarehouseComboBox.SelectedIndex != -1)
            {
                // Update warehouse info with the selected warehouse and show the stock report
                warehouse = warehouses[WarehouseComboBox.SelectedIndex];

                UpdateInfo();

                ReportsComboBox.SelectedIndex = 0;
                RefreshReportDisplay();
            }
            else
            {
                warehouse = null;
                ReportsComboBox.SelectedIndex = -1;
            }
        }

        private void FromDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            // Update the from date and reload the displayed report
            fromDate = FromDateTimePicker.Value.Date;
            ToDateTimePicker.MinDate = fromDate;

            RefreshReportDisplay();
        }

        private void ToDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            // Update the to date and reload the displayed report
            toDate = ToDateTimePicker.Value.Date;
            FromDateTimePicker.MaxDate = toDate;

            RefreshReportDisplay();
        }

        private void ReportsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ensure date pick is enabled
            FromDateTimePicker.Enabled = true;
            ToDateTimePicker.Enabled = true;

            // Display the selected report type
            switch (ReportsComboBox.SelectedIndex)
            {
                case 0:
                    // Disable date pick for stock display only
                    FromDateTimePicker.Enabled = false;
                    ToDateTimePicker.Enabled = false;

                    UpdateStockDisplay();
                    break;

                case 1:
                    UpdateImportsDisplay();
                    break;

                case 2:
                    UpdateExportsDisplay();
                    break;

                case 3:
                    UpdateTransfersDisplay();
                    break;
            }
        }
    }
}
