namespace Warehouse_Management_App.Forms
{
    partial class WarehousesReportForm
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
            WarehouseComboBox = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            label8 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            ManagerNameLabel = new Label();
            WarehouseAddressLabel = new Label();
            WarehouseNameLabel = new Label();
            label2 = new Label();
            ReportDataGridView = new DataGridView();
            FromDateTimePicker = new DateTimePicker();
            label9 = new Label();
            label10 = new Label();
            ToDateTimePicker = new DateTimePicker();
            label13 = new Label();
            ReportsComboBox = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ReportDataGridView).BeginInit();
            SuspendLayout();
            // 
            // WarehouseComboBox
            // 
            WarehouseComboBox.BackColor = Color.FromArgb(45, 62, 80);
            WarehouseComboBox.FlatStyle = FlatStyle.Flat;
            WarehouseComboBox.ForeColor = Color.White;
            WarehouseComboBox.FormattingEnabled = true;
            WarehouseComboBox.Location = new Point(103, 142);
            WarehouseComboBox.MaxDropDownItems = 5;
            WarehouseComboBox.Name = "WarehouseComboBox";
            WarehouseComboBox.Size = new Size(404, 24);
            WarehouseComboBox.TabIndex = 0;
            WarehouseComboBox.SelectedIndexChanged += WarehouseComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(103, 123);
            label3.Name = "label3";
            label3.Size = new Size(138, 16);
            label3.TabIndex = 5;
            label3.Text = "Select Warehouse";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 50);
            label1.Name = "label1";
            label1.Size = new Size(295, 32);
            label1.TabIndex = 7;
            label1.Text = "Warehouse Report";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(693, 117);
            label8.Name = "label8";
            label8.Size = new Size(183, 23);
            label8.TabIndex = 8;
            label8.Text = "Warehouse Info";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 62, 80);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(ManagerNameLabel);
            panel1.Controls.Add(WarehouseAddressLabel);
            panel1.Controls.Add(WarehouseNameLabel);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(693, 142);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20);
            panel1.Size = new Size(522, 113);
            panel1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(23, 48);
            label5.Name = "label5";
            label5.Size = new Size(75, 16);
            label5.TabIndex = 5;
            label5.Text = "Manager:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 76);
            label4.Name = "label4";
            label4.Size = new Size(71, 16);
            label4.TabIndex = 5;
            label4.Text = "Address:";
            // 
            // ManagerNameLabel
            // 
            ManagerNameLabel.AutoSize = true;
            ManagerNameLabel.Font = new Font("Verdana", 9.75F);
            ManagerNameLabel.Location = new Point(104, 48);
            ManagerNameLabel.Name = "ManagerNameLabel";
            ManagerNameLabel.Size = new Size(104, 16);
            ManagerNameLabel.TabIndex = 5;
            ManagerNameLabel.Text = "Manager Name";
            // 
            // WarehouseAddressLabel
            // 
            WarehouseAddressLabel.AutoSize = true;
            WarehouseAddressLabel.Font = new Font("Verdana", 9.75F);
            WarehouseAddressLabel.Location = new Point(104, 76);
            WarehouseAddressLabel.Name = "WarehouseAddressLabel";
            WarehouseAddressLabel.Size = new Size(136, 16);
            WarehouseAddressLabel.TabIndex = 5;
            WarehouseAddressLabel.Text = "Warehouse Address";
            // 
            // WarehouseNameLabel
            // 
            WarehouseNameLabel.AutoSize = true;
            WarehouseNameLabel.Font = new Font("Verdana", 9.75F);
            WarehouseNameLabel.Location = new Point(104, 20);
            WarehouseNameLabel.Name = "WarehouseNameLabel";
            WarehouseNameLabel.Size = new Size(120, 16);
            WarehouseNameLabel.TabIndex = 5;
            WarehouseNameLabel.Text = "Warehouse Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 20);
            label2.Name = "label2";
            label2.Size = new Size(54, 16);
            label2.TabIndex = 5;
            label2.Text = "Name:";
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
            ReportDataGridView.Location = new Point(103, 321);
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
            ReportDataGridView.Size = new Size(1112, 346);
            ReportDataGridView.TabIndex = 3;
            // 
            // FromDateTimePicker
            // 
            FromDateTimePicker.Format = DateTimePickerFormat.Short;
            FromDateTimePicker.Location = new Point(887, 292);
            FromDateTimePicker.Name = "FromDateTimePicker";
            FromDateTimePicker.Size = new Size(161, 23);
            FromDateTimePicker.TabIndex = 1;
            FromDateTimePicker.ValueChanged += FromDateTimePicker_ValueChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(887, 273);
            label9.Name = "label9";
            label9.Size = new Size(45, 16);
            label9.TabIndex = 88;
            label9.Text = "From";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(1054, 273);
            label10.Name = "label10";
            label10.Size = new Size(24, 16);
            label10.TabIndex = 88;
            label10.Text = "To";
            // 
            // ToDateTimePicker
            // 
            ToDateTimePicker.Format = DateTimePickerFormat.Short;
            ToDateTimePicker.Location = new Point(1054, 292);
            ToDateTimePicker.Name = "ToDateTimePicker";
            ToDateTimePicker.Size = new Size(161, 23);
            ToDateTimePicker.TabIndex = 2;
            ToDateTimePicker.ValueChanged += ToDateTimePicker_ValueChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(103, 272);
            label13.Name = "label13";
            label13.Size = new Size(104, 16);
            label13.TabIndex = 5;
            label13.Text = "Select Report";
            // 
            // ReportsComboBox
            // 
            ReportsComboBox.BackColor = Color.FromArgb(45, 62, 80);
            ReportsComboBox.FlatStyle = FlatStyle.Flat;
            ReportsComboBox.ForeColor = Color.White;
            ReportsComboBox.FormattingEnabled = true;
            ReportsComboBox.Location = new Point(103, 291);
            ReportsComboBox.MaxDropDownItems = 5;
            ReportsComboBox.Name = "ReportsComboBox";
            ReportsComboBox.Size = new Size(404, 24);
            ReportsComboBox.TabIndex = 0;
            ReportsComboBox.SelectedIndexChanged += ReportsComboBox_SelectedIndexChanged;
            // 
            // WarehousesReportForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(52, 73, 94);
            ClientSize = new Size(1268, 720);
            Controls.Add(ToDateTimePicker);
            Controls.Add(FromDateTimePicker);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(ReportDataGridView);
            Controls.Add(panel1);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(ReportsComboBox);
            Controls.Add(WarehouseComboBox);
            Controls.Add(label13);
            Controls.Add(label3);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "WarehousesReportForm";
            Padding = new Padding(50);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WarehousesReportForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ReportDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox WarehouseComboBox;
        private Label label3;
        private Label label1;
        private Label label8;
        private Panel panel1;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label ManagerNameLabel;
        private Label WarehouseAddressLabel;
        private Label WarehouseNameLabel;
        private DataGridView ReportDataGridView;
        private DateTimePicker FromDateTimePicker;
        private Label label9;
        private Label label10;
        private DateTimePicker ToDateTimePicker;
        private Label label13;
        private ComboBox ReportsComboBox;
    }
}