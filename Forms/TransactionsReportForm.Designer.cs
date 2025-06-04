namespace Warehouse_Management_App.Forms
{
    partial class TransactionsReportForm
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
            WarehousesCheckedListBox = new CheckedListBox();
            label1 = new Label();
            label13 = new Label();
            ReportDataGridView = new DataGridView();
            ReportsComboBox = new ComboBox();
            label7 = new Label();
            ToDateTimePicker = new DateTimePicker();
            FromDateTimePicker = new DateTimePicker();
            label10 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)ReportDataGridView).BeginInit();
            SuspendLayout();
            // 
            // WarehousesCheckedListBox
            // 
            WarehousesCheckedListBox.BackColor = Color.FromArgb(45, 62, 80);
            WarehousesCheckedListBox.BorderStyle = BorderStyle.FixedSingle;
            WarehousesCheckedListBox.CheckOnClick = true;
            WarehousesCheckedListBox.ForeColor = Color.White;
            WarehousesCheckedListBox.FormattingEnabled = true;
            WarehousesCheckedListBox.HorizontalScrollbar = true;
            WarehousesCheckedListBox.Location = new Point(887, 92);
            WarehousesCheckedListBox.Name = "WarehousesCheckedListBox";
            WarehousesCheckedListBox.Size = new Size(328, 164);
            WarehousesCheckedListBox.TabIndex = 0;
            WarehousesCheckedListBox.ItemCheck += WarehousesCheckedListBox_ItemCheck;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 50);
            label1.Name = "label1";
            label1.Size = new Size(461, 32);
            label1.TabIndex = 111;
            label1.Text = "Products Transactions Report";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(887, 73);
            label13.Name = "label13";
            label13.Size = new Size(146, 16);
            label13.TabIndex = 109;
            label13.Text = "Select Warehouses";
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
            ReportDataGridView.Location = new Point(97, 321);
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
            ReportDataGridView.TabIndex = 118;
            // 
            // ReportsComboBox
            // 
            ReportsComboBox.BackColor = Color.FromArgb(45, 62, 80);
            ReportsComboBox.FlatStyle = FlatStyle.Flat;
            ReportsComboBox.ForeColor = Color.White;
            ReportsComboBox.FormattingEnabled = true;
            ReportsComboBox.Location = new Point(97, 294);
            ReportsComboBox.MaxDropDownItems = 5;
            ReportsComboBox.Name = "ReportsComboBox";
            ReportsComboBox.Size = new Size(322, 24);
            ReportsComboBox.TabIndex = 116;
            ReportsComboBox.SelectedIndexChanged += ReportsComboBox_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(97, 271);
            label7.Name = "label7";
            label7.Size = new Size(104, 16);
            label7.TabIndex = 117;
            label7.Text = "Select Report";
            // 
            // ToDateTimePicker
            // 
            ToDateTimePicker.Format = DateTimePickerFormat.Short;
            ToDateTimePicker.Location = new Point(1054, 292);
            ToDateTimePicker.Name = "ToDateTimePicker";
            ToDateTimePicker.Size = new Size(161, 23);
            ToDateTimePicker.TabIndex = 113;
            ToDateTimePicker.ValueChanged += ToDateTimePicker_ValueChanged;
            // 
            // FromDateTimePicker
            // 
            FromDateTimePicker.Format = DateTimePickerFormat.Short;
            FromDateTimePicker.Location = new Point(887, 292);
            FromDateTimePicker.Name = "FromDateTimePicker";
            FromDateTimePicker.Size = new Size(161, 23);
            FromDateTimePicker.TabIndex = 112;
            FromDateTimePicker.ValueChanged += FromDateTimePicker_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(1054, 273);
            label10.Name = "label10";
            label10.Size = new Size(24, 16);
            label10.TabIndex = 115;
            label10.Text = "To";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(887, 273);
            label9.Name = "label9";
            label9.Size = new Size(45, 16);
            label9.TabIndex = 114;
            label9.Text = "From";
            // 
            // TransactionsReportForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(52, 73, 94);
            ClientSize = new Size(1268, 720);
            Controls.Add(ReportDataGridView);
            Controls.Add(ReportsComboBox);
            Controls.Add(label7);
            Controls.Add(ToDateTimePicker);
            Controls.Add(FromDateTimePicker);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(WarehousesCheckedListBox);
            Controls.Add(label1);
            Controls.Add(label13);
            DoubleBuffered = true;
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "TransactionsReportForm";
            Padding = new Padding(50);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TransactionsReportForm";
            ((System.ComponentModel.ISupportInitialize)ReportDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox WarehousesCheckedListBox;
        private Label label1;
        private Label label13;
        private DataGridView ReportDataGridView;
        private ComboBox ReportsComboBox;
        private Label label7;
        private DateTimePicker ToDateTimePicker;
        private DateTimePicker FromDateTimePicker;
        private Label label10;
        private Label label9;
    }
}