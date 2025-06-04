namespace Warehouse_Management_App.Forms
{
    partial class TransfersForm
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
            ProductsDataGridView = new DataGridView();
            ProductQuantityNumeric = new NumericUpDown();
            RemoveProductButton = new Button();
            AddProductButton = new Button();
            SaveButton = new Button();
            panel1 = new Panel();
            ProductsComboBox = new ComboBox();
            SourceWarehousesComboBox = new ComboBox();
            SuppliersComboBox = new ComboBox();
            label6 = new Label();
            label4 = new Label();
            label11 = new Label();
            label3 = new Label();
            label2 = new Label();
            label8 = new Label();
            label1 = new Label();
            label5 = new Label();
            DestinationWarehousesComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)ProductsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductQuantityNumeric).BeginInit();
            SuspendLayout();
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
            ProductsDataGridView.Location = new Point(103, 357);
            ProductsDataGridView.MultiSelect = false;
            ProductsDataGridView.Name = "ProductsDataGridView";
            ProductsDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            ProductsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(45, 63, 80);
            dataGridViewCellStyle4.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            ProductsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            ProductsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductsDataGridView.Size = new Size(864, 208);
            ProductsDataGridView.TabIndex = 6;
            // 
            // ProductQuantityNumeric
            // 
            ProductQuantityNumeric.BackColor = Color.FromArgb(45, 62, 80);
            ProductQuantityNumeric.BorderStyle = BorderStyle.FixedSingle;
            ProductQuantityNumeric.ForeColor = Color.White;
            ProductQuantityNumeric.Location = new Point(563, 273);
            ProductQuantityNumeric.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            ProductQuantityNumeric.Name = "ProductQuantityNumeric";
            ProductQuantityNumeric.Size = new Size(106, 23);
            ProductQuantityNumeric.TabIndex = 4;
            ProductQuantityNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
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
            RemoveProductButton.Location = new Point(769, 327);
            RemoveProductButton.Name = "RemoveProductButton";
            RemoveProductButton.Size = new Size(198, 24);
            RemoveProductButton.TabIndex = 7;
            RemoveProductButton.Text = "Remove Selected Item";
            RemoveProductButton.UseVisualStyleBackColor = false;
            RemoveProductButton.Click += RemoveProductButton_Click;
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
            AddProductButton.Location = new Point(769, 271);
            AddProductButton.Name = "AddProductButton";
            AddProductButton.Size = new Size(198, 24);
            AddProductButton.TabIndex = 5;
            AddProductButton.Text = "Add";
            AddProductButton.UseVisualStyleBackColor = false;
            AddProductButton.Click += AddProductButton_Click;
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
            panel1.Location = new Point(53, 192);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 2);
            panel1.TabIndex = 78;
            // 
            // ProductsComboBox
            // 
            ProductsComboBox.BackColor = Color.FromArgb(45, 62, 80);
            ProductsComboBox.FlatStyle = FlatStyle.Flat;
            ProductsComboBox.ForeColor = Color.White;
            ProductsComboBox.FormattingEnabled = true;
            ProductsComboBox.Location = new Point(103, 272);
            ProductsComboBox.MaxDropDownItems = 5;
            ProductsComboBox.Name = "ProductsComboBox";
            ProductsComboBox.Size = new Size(404, 24);
            ProductsComboBox.TabIndex = 3;
            ProductsComboBox.SelectedIndexChanged += ProductsComboBox_SelectedIndexChanged;
            // 
            // SourceWarehousesComboBox
            // 
            SourceWarehousesComboBox.BackColor = Color.FromArgb(45, 62, 80);
            SourceWarehousesComboBox.FlatStyle = FlatStyle.Flat;
            SourceWarehousesComboBox.ForeColor = Color.White;
            SourceWarehousesComboBox.FormattingEnabled = true;
            SourceWarehousesComboBox.Location = new Point(103, 137);
            SourceWarehousesComboBox.MaxDropDownItems = 5;
            SourceWarehousesComboBox.Name = "SourceWarehousesComboBox";
            SourceWarehousesComboBox.Size = new Size(404, 24);
            SourceWarehousesComboBox.TabIndex = 1;
            SourceWarehousesComboBox.SelectedIndexChanged += SourceWarehousesComboBox_SelectedIndexChanged;
            // 
            // SuppliersComboBox
            // 
            SuppliersComboBox.BackColor = Color.FromArgb(45, 62, 80);
            SuppliersComboBox.FlatStyle = FlatStyle.Flat;
            SuppliersComboBox.ForeColor = Color.White;
            SuppliersComboBox.FormattingEnabled = true;
            SuppliersComboBox.Location = new Point(769, 63);
            SuppliersComboBox.MaxDropDownItems = 5;
            SuppliersComboBox.Name = "SuppliersComboBox";
            SuppliersComboBox.Size = new Size(198, 24);
            SuppliersComboBox.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(563, 253);
            label6.Name = "label6";
            label6.Size = new Size(70, 16);
            label6.TabIndex = 74;
            label6.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(103, 253);
            label4.Name = "label4";
            label4.Size = new Size(112, 16);
            label4.TabIndex = 73;
            label4.Text = "Select Product";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(103, 118);
            label11.Name = "label11";
            label11.Size = new Size(192, 16);
            label11.TabIndex = 72;
            label11.Text = "Select Source Warehouse";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(648, 68);
            label3.Name = "label3";
            label3.Size = new Size(115, 16);
            label3.TabIndex = 71;
            label3.Text = "Select Supplier";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(103, 325);
            label2.Name = "label2";
            label2.Size = new Size(178, 23);
            label2.TabIndex = 69;
            label2.Text = "Added Products";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(103, 211);
            label8.Name = "label8";
            label8.Size = new Size(211, 23);
            label8.TabIndex = 70;
            label8.Text = "Available Products";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 52);
            label1.Name = "label1";
            label1.Size = new Size(283, 32);
            label1.TabIndex = 68;
            label1.Text = "Transfer Products";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(563, 118);
            label5.Name = "label5";
            label5.Size = new Size(225, 16);
            label5.TabIndex = 72;
            label5.Text = "Select Destination Warehouse";
            // 
            // DestinationWarehousesComboBox
            // 
            DestinationWarehousesComboBox.BackColor = Color.FromArgb(45, 62, 80);
            DestinationWarehousesComboBox.FlatStyle = FlatStyle.Flat;
            DestinationWarehousesComboBox.ForeColor = Color.White;
            DestinationWarehousesComboBox.FormattingEnabled = true;
            DestinationWarehousesComboBox.Location = new Point(563, 137);
            DestinationWarehousesComboBox.MaxDropDownItems = 5;
            DestinationWarehousesComboBox.Name = "DestinationWarehousesComboBox";
            DestinationWarehousesComboBox.Size = new Size(404, 24);
            DestinationWarehousesComboBox.TabIndex = 2;
            // 
            // TransfersForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(52, 73, 94);
            ClientSize = new Size(1020, 680);
            Controls.Add(ProductsDataGridView);
            Controls.Add(ProductQuantityNumeric);
            Controls.Add(RemoveProductButton);
            Controls.Add(AddProductButton);
            Controls.Add(SaveButton);
            Controls.Add(panel1);
            Controls.Add(ProductsComboBox);
            Controls.Add(DestinationWarehousesComboBox);
            Controls.Add(SourceWarehousesComboBox);
            Controls.Add(SuppliersComboBox);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label11);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label1);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "TransfersForm";
            Padding = new Padding(50);
            Text = "TransfersForm";
            ((System.ComponentModel.ISupportInitialize)ProductsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductQuantityNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ProductsDataGridView;
        private NumericUpDown ProductQuantityNumeric;
        private Button RemoveProductButton;
        private Button AddProductButton;
        private Button SaveButton;
        private Panel panel1;
        private ComboBox ProductsComboBox;
        private ComboBox SourceWarehousesComboBox;
        private ComboBox SuppliersComboBox;
        private Label label6;
        private Label label4;
        private Label label11;
        private Label label3;
        private Label label2;
        private Label label8;
        private Label label1;
        private Label label5;
        private ComboBox DestinationWarehousesComboBox;
    }
}