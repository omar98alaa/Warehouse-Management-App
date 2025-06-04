namespace Warehouse_Management_App.Forms
{
    partial class StockReportForm
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
            StockDataGridView = new DataGridView();
            label6 = new Label();
            label1 = new Label();
            WarehouseComboBox = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            DaysNumeric = new NumericUpDown();
            ExpiryRadioButton = new RadioButton();
            InStorageRadioButton = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)StockDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DaysNumeric).BeginInit();
            SuspendLayout();
            // 
            // StockDataGridView
            // 
            StockDataGridView.AllowUserToAddRows = false;
            StockDataGridView.AllowUserToDeleteRows = false;
            StockDataGridView.AllowUserToResizeRows = false;
            StockDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StockDataGridView.BackgroundColor = Color.FromArgb(45, 62, 80);
            StockDataGridView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            StockDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            StockDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            StockDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            StockDataGridView.Location = new Point(103, 308);
            StockDataGridView.MultiSelect = false;
            StockDataGridView.Name = "StockDataGridView";
            StockDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 62, 80);
            dataGridViewCellStyle3.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            StockDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(45, 62, 80);
            dataGridViewCellStyle4.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            StockDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            StockDataGridView.Size = new Size(1124, 359);
            StockDataGridView.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(103, 282);
            label6.Name = "label6";
            label6.Size = new Size(70, 23);
            label6.TabIndex = 94;
            label6.Text = "Stock";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 50);
            label1.Name = "label1";
            label1.Size = new Size(209, 32);
            label1.TabIndex = 92;
            label1.Text = "Stock Report";
            // 
            // WarehouseComboBox
            // 
            WarehouseComboBox.BackColor = Color.FromArgb(45, 62, 80);
            WarehouseComboBox.FlatStyle = FlatStyle.Flat;
            WarehouseComboBox.ForeColor = Color.White;
            WarehouseComboBox.FormattingEnabled = true;
            WarehouseComboBox.Location = new Point(103, 135);
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
            label3.Location = new Point(103, 116);
            label3.Name = "label3";
            label3.Size = new Size(138, 16);
            label3.TabIndex = 90;
            label3.Text = "Select Warehouse";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(103, 186);
            label2.Name = "label2";
            label2.Size = new Size(43, 16);
            label2.TabIndex = 90;
            label2.Text = "Days";
            // 
            // DaysNumeric
            // 
            DaysNumeric.BackColor = Color.FromArgb(45, 62, 80);
            DaysNumeric.BorderStyle = BorderStyle.FixedSingle;
            DaysNumeric.ForeColor = Color.White;
            DaysNumeric.Location = new Point(103, 206);
            DaysNumeric.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            DaysNumeric.Name = "DaysNumeric";
            DaysNumeric.Size = new Size(123, 23);
            DaysNumeric.TabIndex = 1;
            DaysNumeric.ValueChanged += DaysNumeric_ValueChanged;
            // 
            // ExpiryRadioButton
            // 
            ExpiryRadioButton.AutoSize = true;
            ExpiryRadioButton.FlatAppearance.BorderSize = 0;
            ExpiryRadioButton.FlatAppearance.CheckedBackColor = Color.FromArgb(27, 188, 155);
            ExpiryRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            ExpiryRadioButton.Location = new Point(376, 206);
            ExpiryRadioButton.Name = "ExpiryRadioButton";
            ExpiryRadioButton.Size = new Size(175, 20);
            ExpiryRadioButton.TabIndex = 3;
            ExpiryRadioButton.Text = "Remaining Till Expiry";
            ExpiryRadioButton.UseVisualStyleBackColor = true;
            // 
            // InStorageRadioButton
            // 
            InStorageRadioButton.AutoSize = true;
            InStorageRadioButton.Checked = true;
            InStorageRadioButton.FlatAppearance.BorderSize = 0;
            InStorageRadioButton.FlatAppearance.CheckedBackColor = Color.FromArgb(27, 188, 155);
            InStorageRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            InStorageRadioButton.Location = new Point(250, 206);
            InStorageRadioButton.Name = "InStorageRadioButton";
            InStorageRadioButton.Size = new Size(101, 20);
            InStorageRadioButton.TabIndex = 2;
            InStorageRadioButton.TabStop = true;
            InStorageRadioButton.Text = "In Storage";
            InStorageRadioButton.UseVisualStyleBackColor = true;
            InStorageRadioButton.CheckedChanged += InStorageRadioButton_CheckedChanged;
            // 
            // StockReportForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(52, 73, 94);
            ClientSize = new Size(1280, 720);
            Controls.Add(ExpiryRadioButton);
            Controls.Add(InStorageRadioButton);
            Controls.Add(DaysNumeric);
            Controls.Add(StockDataGridView);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(WarehouseComboBox);
            Controls.Add(label3);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "StockReportForm";
            Padding = new Padding(50);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StockReportForm";
            ((System.ComponentModel.ISupportInitialize)StockDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)DaysNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView StockDataGridView;
        private Label label6;
        private Label label1;
        private ComboBox WarehouseComboBox;
        private Label label3;
        private Label label2;
        private NumericUpDown DaysNumeric;
        private RadioButton ExpiryRadioButton;
        private RadioButton InStorageRadioButton;
    }
}