namespace Warehouse_Management_App.Forms
{
    partial class ProductsReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            ToDateTimePicker = new DateTimePicker();
            FromDateTimePicker = new DateTimePicker();
            label10 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            ProductNameLabel = new Label();
            ProductExpiryLabel = new Label();
            ProductCodeLabel = new Label();
            label2 = new Label();
            label8 = new Label();
            label1 = new Label();
            ProductComboBox = new ComboBox();
            label3 = new Label();
            WarehousesCheckedListBox = new CheckedListBox();
            label13 = new Label();
            ReportsComboBox = new ComboBox();
            label7 = new Label();
            ReportDataGridView = new DataGridView();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ReportDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ToDateTimePicker
            // 
            ToDateTimePicker.Format = DateTimePickerFormat.Short;
            ToDateTimePicker.Location = new Point(1054, 294);
            ToDateTimePicker.Name = "ToDateTimePicker";
            ToDateTimePicker.Size = new Size(161, 23);
            ToDateTimePicker.TabIndex = 3;
            ToDateTimePicker.ValueChanged += ToDateTimePicker_ValueChanged;
            // 
            // FromDateTimePicker
            // 
            FromDateTimePicker.Format = DateTimePickerFormat.Short;
            FromDateTimePicker.Location = new Point(887, 294);
            FromDateTimePicker.Name = "FromDateTimePicker";
            FromDateTimePicker.Size = new Size(161, 23);
            FromDateTimePicker.TabIndex = 2;
            FromDateTimePicker.ValueChanged += FromDateTimePicker_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(1054, 275);
            label10.Name = "label10";
            label10.Size = new Size(24, 16);
            label10.TabIndex = 104;
            label10.Text = "To";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(887, 275);
            label9.Name = "label9";
            label9.Size = new Size(45, 16);
            label9.TabIndex = 103;
            label9.Text = "From";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 62, 80);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(ProductNameLabel);
            panel1.Controls.Add(ProductExpiryLabel);
            panel1.Controls.Add(ProductCodeLabel);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(687, 144);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20);
            panel1.Size = new Size(528, 113);
            panel1.TabIndex = 98;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(23, 48);
            label5.Name = "label5";
            label5.Size = new Size(54, 16);
            label5.TabIndex = 5;
            label5.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 76);
            label4.Name = "label4";
            label4.Size = new Size(161, 16);
            label4.TabIndex = 5;
            label4.Text = "Expiry Period (days):";
            // 
            // ProductNameLabel
            // 
            ProductNameLabel.AutoSize = true;
            ProductNameLabel.Font = new Font("Verdana", 9.75F);
            ProductNameLabel.Location = new Point(83, 48);
            ProductNameLabel.Name = "ProductNameLabel";
            ProductNameLabel.Size = new Size(99, 16);
            ProductNameLabel.TabIndex = 5;
            ProductNameLabel.Text = "Product Name";
            // 
            // ProductExpiryLabel
            // 
            ProductExpiryLabel.AutoSize = true;
            ProductExpiryLabel.Font = new Font("Verdana", 9.75F);
            ProductExpiryLabel.Location = new Point(190, 77);
            ProductExpiryLabel.Name = "ProductExpiryLabel";
            ProductExpiryLabel.Size = new Size(147, 16);
            ProductExpiryLabel.TabIndex = 5;
            ProductExpiryLabel.Text = "Product Expiry Period";
            // 
            // ProductCodeLabel
            // 
            ProductCodeLabel.AutoSize = true;
            ProductCodeLabel.Font = new Font("Verdana", 9.75F);
            ProductCodeLabel.Location = new Point(83, 20);
            ProductCodeLabel.Name = "ProductCodeLabel";
            ProductCodeLabel.Size = new Size(96, 16);
            ProductCodeLabel.TabIndex = 5;
            ProductCodeLabel.Text = "Product Code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 20);
            label2.Name = "label2";
            label2.Size = new Size(49, 16);
            label2.TabIndex = 5;
            label2.Text = "Code:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(737, 169);
            label8.Name = "label8";
            label8.Size = new Size(145, 23);
            label8.TabIndex = 93;
            label8.Text = "Product Info";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 50);
            label1.Name = "label1";
            label1.Size = new Size(243, 32);
            label1.TabIndex = 92;
            label1.Text = "Product Report";
            // 
            // ProductComboBox
            // 
            ProductComboBox.BackColor = Color.FromArgb(45, 62, 80);
            ProductComboBox.FlatStyle = FlatStyle.Flat;
            ProductComboBox.ForeColor = Color.White;
            ProductComboBox.FormattingEnabled = true;
            ProductComboBox.Location = new Point(97, 144);
            ProductComboBox.MaxDropDownItems = 5;
            ProductComboBox.Name = "ProductComboBox";
            ProductComboBox.Size = new Size(322, 24);
            ProductComboBox.TabIndex = 0;
            ProductComboBox.SelectedIndexChanged += ProductComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(97, 125);
            label3.Name = "label3";
            label3.Size = new Size(112, 16);
            label3.TabIndex = 90;
            label3.Text = "Select Product";
            // 
            // WarehousesCheckedListBox
            // 
            WarehousesCheckedListBox.BackColor = Color.FromArgb(45, 62, 80);
            WarehousesCheckedListBox.BorderStyle = BorderStyle.FixedSingle;
            WarehousesCheckedListBox.CheckOnClick = true;
            WarehousesCheckedListBox.ForeColor = Color.White;
            WarehousesCheckedListBox.FormattingEnabled = true;
            WarehousesCheckedListBox.HorizontalScrollbar = true;
            WarehousesCheckedListBox.Location = new Point(462, 144);
            WarehousesCheckedListBox.Name = "WarehousesCheckedListBox";
            WarehousesCheckedListBox.Size = new Size(179, 146);
            WarehousesCheckedListBox.TabIndex = 1;
            WarehousesCheckedListBox.ItemCheck += WarehousesCheckedListBox_ItemCheck;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(462, 125);
            label13.Name = "label13";
            label13.Size = new Size(146, 16);
            label13.TabIndex = 90;
            label13.Text = "Select Warehouses";
            // 
            // ReportsComboBox
            // 
            ReportsComboBox.BackColor = Color.FromArgb(45, 62, 80);
            ReportsComboBox.FlatStyle = FlatStyle.Flat;
            ReportsComboBox.ForeColor = Color.White;
            ReportsComboBox.FormattingEnabled = true;
            ReportsComboBox.Location = new Point(97, 293);
            ReportsComboBox.MaxDropDownItems = 5;
            ReportsComboBox.Name = "ReportsComboBox";
            ReportsComboBox.Size = new Size(322, 24);
            ReportsComboBox.TabIndex = 105;
            ReportsComboBox.SelectedIndexChanged += ReportsComboBox_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(97, 274);
            label7.Name = "label7";
            label7.Size = new Size(104, 16);
            label7.TabIndex = 106;
            label7.Text = "Select Report";
            // 
            // ReportDataGridView
            // 
            ReportDataGridView.AllowUserToAddRows = false;
            ReportDataGridView.AllowUserToDeleteRows = false;
            ReportDataGridView.AllowUserToResizeRows = false;
            ReportDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ReportDataGridView.BackgroundColor = Color.FromArgb(45, 62, 80);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(45, 62, 80);
            dataGridViewCellStyle1.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ReportDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ReportDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            ReportDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            ReportDataGridView.Location = new Point(97, 323);
            ReportDataGridView.MultiSelect = false;
            ReportDataGridView.Name = "ReportDataGridView";
            ReportDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            ReportDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(45, 62, 80);
            dataGridViewCellStyle4.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            ReportDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            ReportDataGridView.Size = new Size(1118, 346);
            ReportDataGridView.TabIndex = 107;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(687, 118);
            label6.Name = "label6";
            label6.Size = new Size(145, 23);
            label6.TabIndex = 108;
            label6.Text = "Product Info";
            // 
            // ProductsReportForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(52, 73, 94);
            ClientSize = new Size(1268, 720);
            Controls.Add(label6);
            Controls.Add(ReportDataGridView);
            Controls.Add(ReportsComboBox);
            Controls.Add(label7);
            Controls.Add(WarehousesCheckedListBox);
            Controls.Add(ToDateTimePicker);
            Controls.Add(FromDateTimePicker);
            Controls.Add(panel1);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(ProductComboBox);
            Controls.Add(label13);
            Controls.Add(label3);
            DoubleBuffered = true;
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ProductsReportForm";
            Padding = new Padding(50);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductsReportForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ReportDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker ToDateTimePicker;
        private DateTimePicker FromDateTimePicker;
        private Label label10;
        private Label label9;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label ProductNameLabel;
        private Label ProductExpiryLabel;
        private Label ProductCodeLabel;
        private Label label2;
        private Label label8;
        private Label label1;
        private ComboBox ProductComboBox;
        private Label label3;
        private CheckedListBox WarehousesCheckedListBox;
        private Label label13;
        private ComboBox ReportsComboBox;
        private Label label7;
        private DataGridView ReportDataGridView;
        private Label label6;
    }
}