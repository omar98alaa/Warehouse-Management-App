namespace Warehouse_Management_App.Forms
{
    partial class ImportsForm
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
            SaveButton = new Button();
            panel1 = new Panel();
            SuppliersComboBox = new ComboBox();
            label3 = new Label();
            label8 = new Label();
            label1 = new Label();
            label11 = new Label();
            WarehousesComboBox = new ComboBox();
            label4 = new Label();
            ProductsComboBox = new ComboBox();
            ProductionDateTimePicker = new DateTimePicker();
            label5 = new Label();
            ProductQuantityNumeric = new NumericUpDown();
            label6 = new Label();
            AddProductButton = new Button();
            ProductsDataGridView = new DataGridView();
            RemoveProductButton = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)ProductQuantityNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.FromArgb(22, 160, 134);
            SaveButton.FlatAppearance.BorderSize = 0;
            SaveButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 188, 155);
            SaveButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 188, 155);
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveButton.Location = new Point(837, 587);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(130, 40);
            SaveButton.TabIndex = 8;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(236, 240, 241);
            panel1.Location = new Point(103, 181);
            panel1.Name = "panel1";
            panel1.Size = new Size(864, 1);
            panel1.TabIndex = 44;
            // 
            // SuppliersComboBox
            // 
            SuppliersComboBox.BackColor = Color.FromArgb(45, 62, 80);
            SuppliersComboBox.FlatStyle = FlatStyle.Flat;
            SuppliersComboBox.ForeColor = Color.White;
            SuppliersComboBox.FormattingEnabled = true;
            SuppliersComboBox.Location = new Point(563, 135);
            SuppliersComboBox.MaxDropDownItems = 5;
            SuppliersComboBox.Name = "SuppliersComboBox";
            SuppliersComboBox.Size = new Size(404, 24);
            SuppliersComboBox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(563, 116);
            label3.Name = "label3";
            label3.Size = new Size(115, 16);
            label3.TabIndex = 27;
            label3.Text = "Select Supplier";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(103, 209);
            label8.Name = "label8";
            label8.Size = new Size(152, 23);
            label8.TabIndex = 26;
            label8.Text = "Add Products";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 50);
            label1.Name = "label1";
            label1.Size = new Size(264, 32);
            label1.TabIndex = 25;
            label1.Text = "Import Products";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(103, 116);
            label11.Name = "label11";
            label11.Size = new Size(225, 16);
            label11.TabIndex = 27;
            label11.Text = "Select Destination Warehouse";
            // 
            // WarehousesComboBox
            // 
            WarehousesComboBox.BackColor = Color.FromArgb(45, 62, 80);
            WarehousesComboBox.FlatStyle = FlatStyle.Flat;
            WarehousesComboBox.ForeColor = Color.White;
            WarehousesComboBox.FormattingEnabled = true;
            WarehousesComboBox.Location = new Point(103, 135);
            WarehousesComboBox.MaxDropDownItems = 5;
            WarehousesComboBox.Name = "WarehousesComboBox";
            WarehousesComboBox.Size = new Size(404, 24);
            WarehousesComboBox.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(103, 251);
            label4.Name = "label4";
            label4.Size = new Size(112, 16);
            label4.TabIndex = 27;
            label4.Text = "Select Product";
            // 
            // ProductsComboBox
            // 
            ProductsComboBox.BackColor = Color.FromArgb(45, 62, 80);
            ProductsComboBox.FlatStyle = FlatStyle.Flat;
            ProductsComboBox.ForeColor = Color.White;
            ProductsComboBox.FormattingEnabled = true;
            ProductsComboBox.Location = new Point(103, 270);
            ProductsComboBox.MaxDropDownItems = 5;
            ProductsComboBox.Name = "ProductsComboBox";
            ProductsComboBox.Size = new Size(404, 24);
            ProductsComboBox.TabIndex = 2;
            // 
            // ProductionDateTimePicker
            // 
            ProductionDateTimePicker.Format = DateTimePickerFormat.Short;
            ProductionDateTimePicker.Location = new Point(563, 271);
            ProductionDateTimePicker.Name = "ProductionDateTimePicker";
            ProductionDateTimePicker.Size = new Size(123, 23);
            ProductionDateTimePicker.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(563, 252);
            label5.Name = "label5";
            label5.Size = new Size(123, 16);
            label5.TabIndex = 27;
            label5.Text = "Production Date";
            // 
            // ProductQuantityNumeric
            // 
            ProductQuantityNumeric.BackColor = Color.FromArgb(45, 62, 80);
            ProductQuantityNumeric.BorderStyle = BorderStyle.FixedSingle;
            ProductQuantityNumeric.ForeColor = Color.White;
            ProductQuantityNumeric.Location = new Point(711, 271);
            ProductQuantityNumeric.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            ProductQuantityNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ProductQuantityNumeric.Name = "ProductQuantityNumeric";
            ProductQuantityNumeric.Size = new Size(123, 23);
            ProductQuantityNumeric.TabIndex = 4;
            ProductQuantityNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(711, 252);
            label6.Name = "label6";
            label6.Size = new Size(70, 16);
            label6.TabIndex = 27;
            label6.Text = "Quantity";
            // 
            // AddProductButton
            // 
            AddProductButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AddProductButton.BackColor = Color.FromArgb(22, 160, 134);
            AddProductButton.FlatAppearance.BorderSize = 0;
            AddProductButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 188, 155);
            AddProductButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 188, 155);
            AddProductButton.FlatStyle = FlatStyle.Flat;
            AddProductButton.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddProductButton.Location = new Point(859, 270);
            AddProductButton.Name = "AddProductButton";
            AddProductButton.Size = new Size(108, 24);
            AddProductButton.TabIndex = 5;
            AddProductButton.Text = "Add";
            AddProductButton.UseVisualStyleBackColor = false;
            AddProductButton.Click += AddProductButton_Click;
            // 
            // ProductsDataGridView
            // 
            ProductsDataGridView.AllowUserToAddRows = false;
            ProductsDataGridView.AllowUserToDeleteRows = false;
            ProductsDataGridView.AllowUserToResizeRows = false;
            ProductsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductsDataGridView.BackgroundColor = Color.FromArgb(45, 62, 80);
            ProductsDataGridView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ProductsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ProductsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            ProductsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            ProductsDataGridView.Location = new Point(103, 361);
            ProductsDataGridView.MultiSelect = false;
            ProductsDataGridView.Name = "ProductsDataGridView";
            ProductsDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 62, 80);
            dataGridViewCellStyle3.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            ProductsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(45, 62, 80);
            dataGridViewCellStyle4.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            ProductsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            ProductsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductsDataGridView.Size = new Size(864, 208);
            ProductsDataGridView.TabIndex = 6;
            // 
            // RemoveProductButton
            // 
            RemoveProductButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            RemoveProductButton.BackColor = Color.Maroon;
            RemoveProductButton.FlatAppearance.BorderSize = 0;
            RemoveProductButton.FlatAppearance.MouseDownBackColor = Color.DarkRed;
            RemoveProductButton.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            RemoveProductButton.FlatStyle = FlatStyle.Flat;
            RemoveProductButton.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RemoveProductButton.Location = new Point(769, 331);
            RemoveProductButton.Name = "RemoveProductButton";
            RemoveProductButton.Size = new Size(198, 24);
            RemoveProductButton.TabIndex = 7;
            RemoveProductButton.Text = "Remove Selected Item";
            RemoveProductButton.UseVisualStyleBackColor = false;
            RemoveProductButton.Click += RemoveProductButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(103, 332);
            label2.Name = "label2";
            label2.Size = new Size(178, 23);
            label2.TabIndex = 84;
            label2.Text = "Added Products";
            // 
            // ImportsForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(52, 73, 94);
            ClientSize = new Size(1020, 680);
            Controls.Add(ProductsDataGridView);
            Controls.Add(RemoveProductButton);
            Controls.Add(label2);
            Controls.Add(ProductQuantityNumeric);
            Controls.Add(ProductionDateTimePicker);
            Controls.Add(AddProductButton);
            Controls.Add(SaveButton);
            Controls.Add(panel1);
            Controls.Add(ProductsComboBox);
            Controls.Add(WarehousesComboBox);
            Controls.Add(SuppliersComboBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label11);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(label1);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ImportsForm";
            Padding = new Padding(50);
            Text = "ImportsForm";
            ((System.ComponentModel.ISupportInitialize)ProductQuantityNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveButton;
        private Panel panel1;
        private ComboBox SuppliersComboBox;
        private Label label3;
        private Label label8;
        private Label label1;
        private Label label11;
        private ComboBox WarehousesComboBox;
        private Label label4;
        private ComboBox ProductsComboBox;
        private DateTimePicker ProductionDateTimePicker;
        private Label label5;
        private NumericUpDown ProductQuantityNumeric;
        private Label label6;
        private Button AddProductButton;
        private DataGridView ProductsDataGridView;
        private Button RemoveProductButton;
        private Label label2;
    }
}