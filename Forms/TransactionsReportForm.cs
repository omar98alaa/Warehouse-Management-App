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
    public partial class TransactionsReportForm : Form
    {
        //
        //  Fields
        //
        AppDbContext appDbContext = new AppDbContext();
        List<Warehouse> warehouses;
        DateTime fromDate;
        DateTime toDate;


        //
        //  Constructors
        //
        public TransactionsReportForm()
        {
            InitializeComponent();

            // Set to date to current date
            FromDateTimePicker.MaxDate = DateTime.Now.Date;
            ToDateTimePicker.MaxDate = DateTime.Now.Date;

            // Set from date 30 days before
            FromDateTimePicker.Value = DateTime.Now.AddDays(-30).Date;

            // Add report types
            ReportsComboBox.Items.AddRange(["Stock", "Imports", "Exports", "Transfers"]);

            ReportsComboBox.SelectedIndex = 0;

            // Load all warehouses
            LoadWarehouses();
        }


        //
        //  Methods
        //
        void LoadWarehouses()
        {
            warehouses = (from W in appDbContext.Warehouses orderby W.Name select W).ToList();

            foreach (var W in warehouses)
            {
                WarehousesCheckedListBox.Items.Add(W.Name);
            }
        }

        void UpdateStockDisplay()
        {
            // Get stock for all selected warehouses
            var stock = (
                from WP in appDbContext.WarehouseProducts
                where WarehousesCheckedListBox.CheckedItems.Contains(WP.Warehouse.Name)
                orderby WP.Warehouse.Name, WP.ProductionDate
                select new
                {
                    Code = WP.ProductCode,
                    Product_Name = WP.Product.Name,
                    Warehouse_Name = WP.Warehouse.Name,
                    Production_Date = WP.ProductionDate,
                    Expiry_Date = WP.ProductionDate.AddDays(WP.Product.ExpiryPeriod).Date,
                    Quantity = WP.Quantity
                }
                ).ToList();

            ReportDataGridView.DataSource = stock;

        }

        void UpdateImportsDisplay()
        {
            // Get imports for all selected warehouses in the given period
            var imports = (
                from I in appDbContext.ImportedProducts
                where WarehousesCheckedListBox.CheckedItems.Contains(I.Import.Warehouse.Name) &&
                    fromDate.Date <= I.Import.IssueDate.Date &&
                    I.Import.IssueDate.Date <= toDate.Date
                orderby I.Import.IssueDate descending
                select new
                {
                    Date = I.Import.IssueDate,
                    Code = I.ProductCode,
                    Product_Name = I.Product.Name,
                    Warehouse_Name = I.Import.Warehouse.Name,
                    Production_Date = I.ProductionDate,
                    Expiry_Date = I.ProductionDate.AddDays(I.Product.ExpiryPeriod).Date,
                    Quantity = I.Quantity,
                    Supplier = I.Import.Contact.Email,
                }
                ).ToList();

            ReportDataGridView.DataSource = imports;
        }

        void UpdateExportsDisplay()
        {
            // Get exports for all selected warehouses in the given period
            var exports = (
                from I in appDbContext.ExportedProducts
                where WarehousesCheckedListBox.CheckedItems.Contains(I.Export.Warehouse.Name) &&
                    fromDate.Date <= I.Export.IssueDate.Date &&
                    I.Export.IssueDate.Date <= toDate.Date
                orderby I.Export.IssueDate descending
                select new
                {
                    Date = I.Export.IssueDate,
                    Code = I.ProductCode,
                    Product_Name = I.Product.Name,
                    Warehouse_Name = I.Export.Warehouse.Name,
                    Quantity = I.Quantity,
                    Client = I.Export.Contact.Email,
                }
                ).ToList();

            ReportDataGridView.DataSource = exports;
        }

        void UpdateTransfersDisplay()
        {
            // Get transfered for all selected warehouses in the given period
            var transfers = (
                from I in appDbContext.TransferedProducts
                where (WarehousesCheckedListBox.CheckedItems.Contains(I.Transfer.SourceWarehouse.Name) ||
                    WarehousesCheckedListBox.CheckedItems.Contains(I.Transfer.DestinationWarehouse.Name)) &&
                    fromDate.Date <= I.Transfer.IssueDate.Date &&
                    I.Transfer.IssueDate.Date <= toDate.Date
                orderby I.Transfer.IssueDate descending
                select new
                {
                    Date = I.Transfer.IssueDate,
                    Code = I.ProductCode,
                    Product_Name = I.Product.Name,
                    Source_Warehouse_Name = I.Transfer.SourceWarehouse.Name,
                    Destination_Warehouse_Name = I.Transfer.DestinationWarehouse.Name,
                    Production_Date = I.ProductionDate,
                    Expiry_Date = I.ProductionDate.AddDays(I.Product.ExpiryPeriod).Date,
                    Quantity = I.Quantity,
                    Supplier = I.Transfer.Contact.Email,
                }
                ).ToList();

            ReportDataGridView.DataSource = transfers;
        }

        void RefreshReportDisplay()
        {
            var idx = ReportsComboBox.SelectedIndex;
            ReportsComboBox.SelectedIndex = -1;
            ReportsComboBox.SelectedIndex = idx;
        }

        //
        //  Event handlers
        //
        private void FromDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            // Update the period lower limit
            fromDate = FromDateTimePicker.Value.Date;
            ToDateTimePicker.MinDate = fromDate;

            RefreshReportDisplay();
        }

        private void ToDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            // Update the period upper limit
            toDate = ToDateTimePicker.Value.Date;
            FromDateTimePicker.MaxDate = toDate;

            RefreshReportDisplay();
        }

        private void WarehousesCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Update displayed data to include/exclude a warehouse
            this.BeginInvoke(() =>
            {
                RefreshReportDisplay();
            });

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
