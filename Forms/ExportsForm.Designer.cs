namespace Warehouse_Management_App.Forms
{
    partial class ExportsForm
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
            ProductQuantityNumeric = new NumericUpDown();
            AddProductButton = new Button();
            SaveButton = new Button();
            panel1 = new Panel();
            ProductsComboBox = new ComboBox();
            WarehousesComboBox = new ComboBox();
            ClientsComboBox = new ComboBox();
            label6 = new Label();
            label4 = new Label();
            label11 = new Label();
            label3 = new Label();
            label8 = new Label();
            label1 = new Label();
            ProductsDataGridView = new DataGridView();
            RemoveProductButton = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)ProductQuantityNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ProductQuantityNumeric
            // 
            ProductQuantityNumeric.BackColor = Color.FromArgb(45, 62, 80);
            ProductQuantityNumeric.BorderStyle = BorderStyle.FixedSingle;
            ProductQuantityNumeric.ForeColor = Color.White;
            ProductQuantityNumeric.Location = new Point(563, 277);
            ProductQuantityNumeric.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            ProductQuantityNumeric.Name = "ProductQuantityNumeric";
            ProductQuantityNumeric.Size = new Size(106, 23);
            ProductQuantityNumeric.TabIndex = 3;
            ProductQuantityNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
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
            AddProductButton.Location = new Point(769, 275);
            AddProductButton.Name = "AddProductButton";
            AddProductButton.Size = new Size(198, 24);
            AddProductButton.TabIndex = 4;
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
            SaveButton.TabIndex = 7;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(236, 240, 241);
            panel1.Location = new Point(53, 192);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 1);
            panel1.TabIndex = 60;
            // 
            // ProductsComboBox
            // 
            ProductsComboBox.BackColor = Color.FromArgb(45, 62, 80);
            ProductsComboBox.FlatStyle = FlatStyle.Flat;
            ProductsComboBox.ForeColor = Color.White;
            ProductsComboBox.FormattingEnabled = true;
            ProductsComboBox.Location = new Point(103, 276);
            ProductsComboBox.MaxDropDownItems = 5;
            ProductsComboBox.Name = "ProductsComboBox";
            ProductsComboBox.Size = new Size(404, 24);
            ProductsComboBox.TabIndex = 2;
            ProductsComboBox.SelectedIndexChanged += ProductsComboBox_SelectedIndexChanged;
            // 
            // WarehousesComboBox
            // 
            WarehousesComboBox.BackColor = Color.FromArgb(45, 62, 80);
            WarehousesComboBox.FlatStyle = FlatStyle.Flat;
            WarehousesComboBox.ForeColor = Color.White;
            WarehousesComboBox.FormattingEnabled = true;
            WarehousesComboBox.Location = new Point(103, 137);
            WarehousesComboBox.MaxDropDownItems = 5;
            WarehousesComboBox.Name = "WarehousesComboBox";
            WarehousesComboBox.Size = new Size(404, 24);
            WarehousesComboBox.TabIndex = 0;
            WarehousesComboBox.SelectedIndexChanged += WarehousesComboBox_SelectedIndexChanged;
            // 
            // ClientsComboBox
            // 
            ClientsComboBox.BackColor = Color.FromArgb(45, 62, 80);
            ClientsComboBox.FlatStyle = FlatStyle.Flat;
            ClientsComboBox.ForeColor = Color.White;
            ClientsComboBox.FormattingEnabled = true;
            ClientsComboBox.Location = new Point(563, 137);
            ClientsComboBox.MaxDropDownItems = 5;
            ClientsComboBox.Name = "ClientsComboBox";
            ClientsComboBox.Size = new Size(404, 24);
            ClientsComboBox.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(563, 257);
            label6.Name = "label6";
            label6.Size = new Size(70, 16);
            label6.TabIndex = 56;
            label6.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(103, 257);
            label4.Name = "label4";
            label4.Size = new Size(112, 16);
            label4.TabIndex = 54;
            label4.Text = "Select Product";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(103, 118);
            label11.Name = "label11";
            label11.Size = new Size(192, 16);
            label11.TabIndex = 53;
            label11.Text = "Select Source Warehouse";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(563, 118);
            label3.Name = "label3";
            label3.Size = new Size(98, 16);
            label3.TabIndex = 52;
            label3.Text = "Select Client";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(103, 215);
            label8.Name = "label8";
            label8.Size = new Size(211, 23);
            label8.TabIndex = 51;
            label8.Text = "Available Products";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 52);
            label1.Name = "label1";
            label1.Size = new Size(256, 32);
            label1.TabIndex = 49;
            label1.Text = "Export Products";
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
            ProductsDataGridView.Location = new Point(103, 364);
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
            dataGridViewCellStyle4.BackColor = Color.FromArgb(45, 62, 80);
            dataGridViewCellStyle4.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            ProductsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            ProductsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductsDataGridView.Size = new Size(864, 208);
            ProductsDataGridView.TabIndex = 5;
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
            RemoveProductButton.Location = new Point(769, 334);
            RemoveProductButton.Name = "RemoveProductButton";
            RemoveProductButton.Size = new Size(198, 24);
            RemoveProductButton.TabIndex = 6;
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
            // ExportsForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(52, 73, 94);
            ClientSize = new Size(1020, 680);
            Controls.Add(ProductsDataGridView);
            Controls.Add(RemoveProductButton);
            Controls.Add(label2);
            Controls.Add(ProductQuantityNumeric);
            Controls.Add(AddProductButton);
            Controls.Add(SaveButton);
            Controls.Add(panel1);
            Controls.Add(ProductsComboBox);
            Controls.Add(WarehousesComboBox);
            Controls.Add(ClientsComboBox);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label11);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(label1);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ExportsForm";
            Padding = new Padding(50);
            Text = "ExportsForm";
            ((System.ComponentModel.ISupportInitialize)ProductQuantityNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NumericUpDown ProductQuantityNumeric;
        private Button AddProductButton;
        private Button SaveButton;
        private Panel panel1;
        private ComboBox ProductsComboBox;
        private ComboBox WarehousesComboBox;
        private ComboBox ClientsComboBox;
        private Label label6;
        private Label label4;
        private Label label11;
        private Label label3;
        private Label label8;
        private Label label1;
        private DataGridView ProductsDataGridView;
        private Button RemoveProductButton;
        private Label label2;
    }
}