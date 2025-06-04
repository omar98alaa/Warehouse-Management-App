namespace Warehouse_Management_App.Forms
{
    partial class WarehousesForm
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
            label2 = new Label();
            WarehouseNameTextBox = new TextBox();
            label3 = new Label();
            ManagerNameTextBox = new TextBox();
            label4 = new Label();
            CityTextBox = new TextBox();
            label5 = new Label();
            StreetTextBox = new TextBox();
            AddRadioButton = new RadioButton();
            ModifyRadioButton = new RadioButton();
            label1 = new Label();
            WarehouseComboBox = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel1 = new Panel();
            SaveButton = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            label2.Location = new Point(103, 363);
            label2.Name = "label2";
            label2.Size = new Size(135, 16);
            label2.TabIndex = 1;
            label2.Text = "Warehouse Name";
            // 
            // WarehouseNameTextBox
            // 
            WarehouseNameTextBox.BackColor = Color.FromArgb(45, 62, 80);
            WarehouseNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            WarehouseNameTextBox.Font = new Font("Verdana", 9.75F);
            WarehouseNameTextBox.ForeColor = Color.White;
            WarehouseNameTextBox.Location = new Point(103, 382);
            WarehouseNameTextBox.Name = "WarehouseNameTextBox";
            WarehouseNameTextBox.Size = new Size(864, 23);
            WarehouseNameTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(563, 181);
            label3.Name = "label3";
            label3.Size = new Size(138, 16);
            label3.TabIndex = 1;
            label3.Text = "Select Warehouse";
            // 
            // ManagerNameTextBox
            // 
            ManagerNameTextBox.BackColor = Color.FromArgb(45, 62, 80);
            ManagerNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            ManagerNameTextBox.Font = new Font("Verdana", 9.75F);
            ManagerNameTextBox.ForeColor = Color.White;
            ManagerNameTextBox.Location = new Point(103, 448);
            ManagerNameTextBox.Name = "ManagerNameTextBox";
            ManagerNameTextBox.Size = new Size(864, 23);
            ManagerNameTextBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            label4.Location = new Point(696, 495);
            label4.Name = "label4";
            label4.Size = new Size(36, 16);
            label4.TabIndex = 1;
            label4.Text = "City";
            // 
            // CityTextBox
            // 
            CityTextBox.BackColor = Color.FromArgb(45, 62, 80);
            CityTextBox.BorderStyle = BorderStyle.FixedSingle;
            CityTextBox.Font = new Font("Verdana", 9.75F);
            CityTextBox.ForeColor = Color.White;
            CityTextBox.Location = new Point(696, 514);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(270, 23);
            CityTextBox.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            label5.Location = new Point(343, 495);
            label5.Name = "label5";
            label5.Size = new Size(52, 16);
            label5.TabIndex = 1;
            label5.Text = "Street";
            // 
            // StreetTextBox
            // 
            StreetTextBox.BackColor = Color.FromArgb(45, 62, 80);
            StreetTextBox.BorderStyle = BorderStyle.FixedSingle;
            StreetTextBox.Font = new Font("Verdana", 9.75F);
            StreetTextBox.ForeColor = Color.White;
            StreetTextBox.Location = new Point(343, 515);
            StreetTextBox.Name = "StreetTextBox";
            StreetTextBox.Size = new Size(270, 23);
            StreetTextBox.TabIndex = 5;
            // 
            // AddRadioButton
            // 
            AddRadioButton.AutoSize = true;
            AddRadioButton.Checked = true;
            AddRadioButton.FlatAppearance.BorderSize = 0;
            AddRadioButton.FlatAppearance.CheckedBackColor = Color.FromArgb(27, 188, 155);
            AddRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            AddRadioButton.Location = new Point(103, 144);
            AddRadioButton.Name = "AddRadioButton";
            AddRadioButton.Size = new Size(174, 20);
            AddRadioButton.TabIndex = 0;
            AddRadioButton.TabStop = true;
            AddRadioButton.Text = "Add New Warehouse";
            AddRadioButton.UseVisualStyleBackColor = true;
            AddRadioButton.CheckedChanged += AddRadioButton_CheckedChanged;
            // 
            // ModifyRadioButton
            // 
            ModifyRadioButton.AutoSize = true;
            ModifyRadioButton.FlatAppearance.BorderSize = 0;
            ModifyRadioButton.FlatAppearance.CheckedBackColor = Color.FromArgb(27, 188, 155);
            ModifyRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            ModifyRadioButton.Location = new Point(103, 201);
            ModifyRadioButton.Name = "ModifyRadioButton";
            ModifyRadioButton.Size = new Size(221, 20);
            ModifyRadioButton.TabIndex = 1;
            ModifyRadioButton.Text = "Modify Existing Warehouse";
            ModifyRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 50);
            label1.Name = "label1";
            label1.Size = new Size(405, 32);
            label1.TabIndex = 4;
            label1.Text = "Warehouses Management";
            // 
            // WarehouseComboBox
            // 
            WarehouseComboBox.BackColor = Color.FromArgb(45, 62, 80);
            WarehouseComboBox.FlatStyle = FlatStyle.Flat;
            WarehouseComboBox.ForeColor = Color.White;
            WarehouseComboBox.FormattingEnabled = true;
            WarehouseComboBox.Location = new Point(563, 200);
            WarehouseComboBox.MaxDropDownItems = 5;
            WarehouseComboBox.Name = "WarehouseComboBox";
            WarehouseComboBox.Size = new Size(404, 24);
            WarehouseComboBox.TabIndex = 2;
            WarehouseComboBox.SelectedIndexChanged += WarehouseComboBox_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            label6.Location = new Point(103, 429);
            label6.Name = "label6";
            label6.Size = new Size(116, 16);
            label6.TabIndex = 1;
            label6.Text = "Manager Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            label7.Location = new Point(103, 518);
            label7.Name = "label7";
            label7.Size = new Size(157, 16);
            label7.TabIndex = 1;
            label7.Text = "Warehouse Address:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(103, 293);
            label8.Name = "label8";
            label8.Size = new Size(183, 23);
            label8.TabIndex = 1;
            label8.Text = "Warehouse Info";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(236, 240, 241);
            panel1.Location = new Point(53, 258);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 2);
            panel1.TabIndex = 5;
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
            // WarehousesForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(52, 73, 94);
            ClientSize = new Size(1020, 680);
            Controls.Add(SaveButton);
            Controls.Add(panel1);
            Controls.Add(WarehouseComboBox);
            Controls.Add(ModifyRadioButton);
            Controls.Add(AddRadioButton);
            Controls.Add(StreetTextBox);
            Controls.Add(CityTextBox);
            Controls.Add(ManagerNameTextBox);
            Controls.Add(WarehouseNameTextBox);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(label2);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "WarehousesForm";
            Padding = new Padding(50);
            Text = "WarehousesForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox WarehouseNameTextBox;
        private Label label3;
        private TextBox ManagerNameTextBox;
        private Label label4;
        private TextBox CityTextBox;
        private Label label5;
        private TextBox StreetTextBox;
        private RadioButton AddRadioButton;
        private RadioButton ModifyRadioButton;
        private Label label1;
        private ComboBox WarehouseComboBox;
        private Label label6;
        private Label label7;
        private Label label8;
        private Panel panel1;
        private Button SaveButton;
    }
}