namespace Warehouse_Management_App.Forms
{
    partial class ProductsForm
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
            SaveButton = new Button();
            panel1 = new Panel();
            ProductComboBox = new ComboBox();
            ModifyRadioButton = new RadioButton();
            AddRadioButton = new RadioButton();
            ProductCodeTextBox = new TextBox();
            ProductNameTextBox = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label8 = new Label();
            label1 = new Label();
            label6 = new Label();
            label2 = new Label();
            label4 = new Label();
            ExpiryPeriodNumeric = new NumericUpDown();
            label7 = new Label();
            UnitsCheckedListBox = new CheckedListBox();
            AddUnitButton = new Button();
            panel2 = new Panel();
            label9 = new Label();
            AddUnitTextBox = new TextBox();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)ExpiryPeriodNumeric).BeginInit();
            panel3.SuspendLayout();
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
            SaveButton.Location = new Point(435, 587);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(150, 40);
            SaveButton.TabIndex = 8;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(236, 240, 241);
            panel1.Location = new Point(103, 237);
            panel1.Name = "panel1";
            panel1.Size = new Size(864, 1);
            panel1.TabIndex = 22;
            // 
            // ProductComboBox
            // 
            ProductComboBox.BackColor = Color.FromArgb(45, 62, 80);
            ProductComboBox.FlatStyle = FlatStyle.Flat;
            ProductComboBox.ForeColor = Color.White;
            ProductComboBox.FormattingEnabled = true;
            ProductComboBox.Location = new Point(563, 188);
            ProductComboBox.MaxDropDownItems = 5;
            ProductComboBox.Name = "ProductComboBox";
            ProductComboBox.Size = new Size(404, 24);
            ProductComboBox.TabIndex = 2;
            ProductComboBox.SelectedIndexChanged += ProductComboBox_SelectedIndexChanged;
            // 
            // ModifyRadioButton
            // 
            ModifyRadioButton.AutoSize = true;
            ModifyRadioButton.FlatAppearance.BorderSize = 0;
            ModifyRadioButton.FlatAppearance.CheckedBackColor = Color.FromArgb(27, 188, 155);
            ModifyRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            ModifyRadioButton.Location = new Point(103, 189);
            ModifyRadioButton.Name = "ModifyRadioButton";
            ModifyRadioButton.Size = new Size(195, 20);
            ModifyRadioButton.TabIndex = 1;
            ModifyRadioButton.Text = "Modify Existing Product";
            ModifyRadioButton.UseVisualStyleBackColor = true;
            // 
            // AddRadioButton
            // 
            AddRadioButton.AutoSize = true;
            AddRadioButton.Checked = true;
            AddRadioButton.FlatAppearance.BorderSize = 0;
            AddRadioButton.FlatAppearance.CheckedBackColor = Color.FromArgb(27, 188, 155);
            AddRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            AddRadioButton.Location = new Point(103, 132);
            AddRadioButton.Name = "AddRadioButton";
            AddRadioButton.Size = new Size(148, 20);
            AddRadioButton.TabIndex = 0;
            AddRadioButton.TabStop = true;
            AddRadioButton.Text = "Add New Product";
            AddRadioButton.UseVisualStyleBackColor = true;
            AddRadioButton.CheckedChanged += AddRadioButton_CheckedChanged;
            // 
            // ProductCodeTextBox
            // 
            ProductCodeTextBox.BackColor = Color.FromArgb(45, 62, 80);
            ProductCodeTextBox.BorderStyle = BorderStyle.FixedSingle;
            ProductCodeTextBox.Font = new Font("Verdana", 9.75F);
            ProductCodeTextBox.ForeColor = Color.White;
            ProductCodeTextBox.Location = new Point(103, 423);
            ProductCodeTextBox.Name = "ProductCodeTextBox";
            ProductCodeTextBox.Size = new Size(341, 23);
            ProductCodeTextBox.TabIndex = 4;
            ProductCodeTextBox.KeyPress += ProductCodeTextBox_KeyPress;
            // 
            // ProductNameTextBox
            // 
            ProductNameTextBox.BackColor = Color.FromArgb(45, 62, 80);
            ProductNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            ProductNameTextBox.Font = new Font("Verdana", 9.75F);
            ProductNameTextBox.ForeColor = Color.White;
            ProductNameTextBox.Location = new Point(103, 353);
            ProductNameTextBox.Name = "ProductNameTextBox";
            ProductNameTextBox.Size = new Size(341, 23);
            ProductNameTextBox.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            label5.Location = new Point(103, 474);
            label5.Name = "label5";
            label5.Size = new Size(108, 16);
            label5.TabIndex = 12;
            label5.Text = "Expiry Period:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(563, 169);
            label3.Name = "label3";
            label3.Size = new Size(112, 16);
            label3.TabIndex = 10;
            label3.Text = "Select Product";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(53, 282);
            label8.Name = "label8";
            label8.Size = new Size(145, 23);
            label8.TabIndex = 9;
            label8.Text = "Product Info";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 52);
            label1.Name = "label1";
            label1.Size = new Size(353, 32);
            label1.TabIndex = 8;
            label1.Text = "Products Management";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            label6.Location = new Point(103, 334);
            label6.Name = "label6";
            label6.Size = new Size(109, 16);
            label6.TabIndex = 14;
            label6.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            label2.Location = new Point(103, 404);
            label2.Name = "label2";
            label2.Size = new Size(104, 16);
            label2.TabIndex = 7;
            label2.Text = "Product Code";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            label4.Location = new Point(387, 496);
            label4.Name = "label4";
            label4.Size = new Size(57, 16);
            label4.TabIndex = 12;
            label4.Text = "Day(s)";
            // 
            // ExpiryPeriodNumeric
            // 
            ExpiryPeriodNumeric.BackColor = Color.FromArgb(45, 62, 80);
            ExpiryPeriodNumeric.BorderStyle = BorderStyle.FixedSingle;
            ExpiryPeriodNumeric.ForeColor = Color.White;
            ExpiryPeriodNumeric.Location = new Point(103, 494);
            ExpiryPeriodNumeric.Name = "ExpiryPeriodNumeric";
            ExpiryPeriodNumeric.Size = new Size(278, 23);
            ExpiryPeriodNumeric.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(563, 282);
            label7.Name = "label7";
            label7.Size = new Size(156, 23);
            label7.TabIndex = 9;
            label7.Text = "Product Units";
            // 
            // UnitsCheckedListBox
            // 
            UnitsCheckedListBox.BackColor = Color.FromArgb(45, 62, 80);
            UnitsCheckedListBox.BorderStyle = BorderStyle.FixedSingle;
            UnitsCheckedListBox.CheckOnClick = true;
            UnitsCheckedListBox.ForeColor = Color.White;
            UnitsCheckedListBox.FormattingEnabled = true;
            UnitsCheckedListBox.Location = new Point(774, 335);
            UnitsCheckedListBox.Name = "UnitsCheckedListBox";
            UnitsCheckedListBox.ScrollAlwaysVisible = true;
            UnitsCheckedListBox.Size = new Size(193, 182);
            UnitsCheckedListBox.TabIndex = 7;
            // 
            // AddUnitButton
            // 
            AddUnitButton.BackColor = Color.FromArgb(22, 160, 134);
            AddUnitButton.FlatAppearance.BorderSize = 0;
            AddUnitButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 188, 155);
            AddUnitButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 188, 155);
            AddUnitButton.FlatStyle = FlatStyle.Flat;
            AddUnitButton.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddUnitButton.Location = new Point(23, 107);
            AddUnitButton.Name = "AddUnitButton";
            AddUnitButton.Size = new Size(143, 23);
            AddUnitButton.TabIndex = 1;
            AddUnitButton.Text = "Add";
            AddUnitButton.UseVisualStyleBackColor = false;
            AddUnitButton.Click += AddUnitButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(236, 240, 241);
            panel2.Location = new Point(509, 282);
            panel2.Name = "panel2";
            panel2.Size = new Size(1, 270);
            panel2.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            label9.Location = new Point(23, 20);
            label9.Name = "label9";
            label9.Size = new Size(103, 16);
            label9.TabIndex = 14;
            label9.Text = "Add New Unit";
            // 
            // AddUnitTextBox
            // 
            AddUnitTextBox.BackColor = Color.FromArgb(45, 62, 80);
            AddUnitTextBox.BorderStyle = BorderStyle.FixedSingle;
            AddUnitTextBox.Font = new Font("Verdana", 9.75F);
            AddUnitTextBox.ForeColor = Color.White;
            AddUnitTextBox.Location = new Point(23, 62);
            AddUnitTextBox.Name = "AddUnitTextBox";
            AddUnitTextBox.Size = new Size(143, 23);
            AddUnitTextBox.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(45, 62, 80);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(AddUnitTextBox);
            panel3.Controls.Add(AddUnitButton);
            panel3.Location = new Point(563, 335);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20);
            panel3.Size = new Size(189, 182);
            panel3.TabIndex = 6;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(52, 73, 94);
            ClientSize = new Size(1020, 680);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(UnitsCheckedListBox);
            Controls.Add(ExpiryPeriodNumeric);
            Controls.Add(SaveButton);
            Controls.Add(panel1);
            Controls.Add(ProductComboBox);
            Controls.Add(ModifyRadioButton);
            Controls.Add(AddRadioButton);
            Controls.Add(ProductCodeTextBox);
            Controls.Add(ProductNameTextBox);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(label2);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductsForm";
            Padding = new Padding(50);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductsForm";
            ((System.ComponentModel.ISupportInitialize)ExpiryPeriodNumeric).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveButton;
        private Panel panel1;
        private ComboBox ProductComboBox;
        private RadioButton ModifyRadioButton;
        private RadioButton AddRadioButton;
        private TextBox ProductCodeTextBox;
        private TextBox ProductNameTextBox;
        private Label label5;
        private Label label3;
        private Label label8;
        private Label label1;
        private Label label6;
        private Label label2;
        private Label label4;
        private NumericUpDown ExpiryPeriodNumeric;
        private Label label7;
        private CheckedListBox UnitsCheckedListBox;
        private Button AddUnitButton;
        private Panel panel2;
        private Label label9;
        private TextBox AddUnitTextBox;
        private Panel panel3;
    }
}