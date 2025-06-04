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
    public partial class DashboardForm : Form
    {
        //
        //  Fieds
        //
        AppDbContext m_appDbContext = new AppDbContext();


        //
        //  Constructors
        //
        public DashboardForm()
        {
            InitializeComponent();

            // Get the overview info
            WarehousesCountLabel.Text = (from W in m_appDbContext.Warehouses select W.ID).Count().ToString();
            SuppliersCountLabel.Text = (from C in m_appDbContext.Contacts where C.Type == ContactType.Supplier select C.ID).Count().ToString();
            ClientsCountLabel.Text = (from C in m_appDbContext.Contacts where C.Type == ContactType.Client select C.ID).Count().ToString();
            StockCountLabel.Text = (from WP in m_appDbContext.WarehouseProducts select WP.ID).Count().ToString();
            ImportsCountLabel.Text = (from I in m_appDbContext.Imports select I.ID).Count().ToString();
            ExportsCountLabel.Text = (from E in m_appDbContext.Exports select E.ID).Count().ToString();
        }


        //
        //  Event handlers
        //
        private void WarehouseReportButton_Click(object sender, EventArgs e)
        {
            var warehouseReportForm = new WarehousesReportForm();

            warehouseReportForm.ShowDialog();
        }

        private void ProductReportButton_Click(object sender, EventArgs e)
        {
            var warehouseReportForm = new ProductsReportForm();

            warehouseReportForm.ShowDialog();
        }

        private void TransactionsFormButton_Click(object sender, EventArgs e)
        {
            var warehouseReportForm = new TransactionsReportForm();

            warehouseReportForm.ShowDialog();
        }

        private void StockReportFormButton_Click(object sender, EventArgs e)
        {
            var warehouseReportForm = new StockReportForm();

            warehouseReportForm.ShowDialog();
        }
    }
}
