namespace Warehouse_Management_App.Forms
{
    partial class ContactsForm
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
            ContactsComboBox = new ComboBox();
            ModifyRadioButton = new RadioButton();
            AddRadioButton = new RadioButton();
            ContactWebsiteTextBox = new TextBox();
            ContactMobileTextBox = new TextBox();
            ContactEmailTextBox = new TextBox();
            ContactNameTextBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label8 = new Label();
            label1 = new Label();
            label6 = new Label();
            label2 = new Label();
            ContactTypeComboBox = new ComboBox();
            label9 = new Label();
            label7 = new Label();
            ContactTelephoneTextBox = new TextBox();
            label10 = new Label();
            ContactFaxTextBox = new TextBox();
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
            SaveButton.Location = new Point(837, 589);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(130, 40);
            SaveButton.TabIndex = 10;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(236, 240, 241);
            panel1.Location = new Point(103, 262);
            panel1.Name = "panel1";
            panel1.Size = new Size(864, 1);
            panel1.TabIndex = 22;
            // 
            // ContactsComboBox
            // 
            ContactsComboBox.BackColor = Color.FromArgb(45, 62, 80);
            ContactsComboBox.FlatStyle = FlatStyle.Flat;
            ContactsComboBox.ForeColor = Color.White;
            ContactsComboBox.FormattingEnabled = true;
            ContactsComboBox.Location = new Point(563, 202);
            ContactsComboBox.MaxDropDownItems = 5;
            ContactsComboBox.Name = "ContactsComboBox";
            ContactsComboBox.Size = new Size(404, 24);
            ContactsComboBox.TabIndex = 3;
            ContactsComboBox.SelectedIndexChanged += ContactsComboBox_SelectedIndexChanged;
            // 
            // ModifyRadioButton
            // 
            ModifyRadioButton.AutoSize = true;
            ModifyRadioButton.FlatAppearance.BorderSize = 0;
            ModifyRadioButton.FlatAppearance.CheckedBackColor = Color.FromArgb(27, 188, 155);
            ModifyRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            ModifyRadioButton.Location = new Point(103, 203);
            ModifyRadioButton.Name = "ModifyRadioButton";
            ModifyRadioButton.Size = new Size(196, 20);
            ModifyRadioButton.TabIndex = 2;
            ModifyRadioButton.Text = "Modify Existing Contact";
            ModifyRadioButton.UseVisualStyleBackColor = true;
            // 
            // AddRadioButton
            // 
            AddRadioButton.AutoSize = true;
            AddRadioButton.Checked = true;
            AddRadioButton.FlatAppearance.BorderSize = 0;
            AddRadioButton.FlatAppearance.CheckedBackColor = Color.FromArgb(27, 188, 155);
            AddRadioButton.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            AddRadioButton.Location = new Point(103, 146);
            AddRadioButton.Name = "AddRadioButton";
            AddRadioButton.Size = new Size(149, 20);
            AddRadioButton.TabIndex = 1;
            AddRadioButton.TabStop = true;
            AddRadioButton.Text = "Add New Contact";
            AddRadioButton.UseVisualStyleBackColor = true;
            AddRadioButton.CheckedChanged += AddRadioButton_CheckedChanged;
            // 
            // ContactWebsiteTextBox
            // 
            ContactWebsiteTextBox.BackColor = Color.FromArgb(45, 62, 80);
            ContactWebsiteTextBox.BorderStyle = BorderStyle.FixedSingle;
            ContactWebsiteTextBox.Font = new Font("Verdana", 9.75F);
            ContactWebsiteTextBox.ForeColor = Color.White;
            ContactWebsiteTextBox.Location = new Point(103, 517);
            ContactWebsiteTextBox.Name = "ContactWebsiteTextBox";
            ContactWebsiteTextBox.Size = new Size(404, 23);
            ContactWebsiteTextBox.TabIndex = 6;
            // 
            // ContactMobileTextBox
            // 
            ContactMobileTextBox.BackColor = Color.FromArgb(45, 62, 80);
            ContactMobileTextBox.BorderStyle = BorderStyle.FixedSingle;
            ContactMobileTextBox.Font = new Font("Verdana", 9.75F);
            ContactMobileTextBox.ForeColor = Color.White;
            ContactMobileTextBox.Location = new Point(563, 384);
            ContactMobileTextBox.MaxLength = 11;
            ContactMobileTextBox.Name = "ContactMobileTextBox";
            ContactMobileTextBox.Size = new Size(404, 23);
            ContactMobileTextBox.TabIndex = 7;
            ContactMobileTextBox.KeyPress += ContactMobileTextBox_KeyPress;
            // 
            // ContactEmailTextBox
            // 
            ContactEmailTextBox.BackColor = Color.FromArgb(45, 62, 80);
            ContactEmailTextBox.BorderStyle = BorderStyle.FixedSingle;
            ContactEmailTextBox.Font = new Font("Verdana", 9.75F);
            ContactEmailTextBox.ForeColor = Color.White;
            ContactEmailTextBox.Location = new Point(103, 450);
            ContactEmailTextBox.Name = "ContactEmailTextBox";
            ContactEmailTextBox.Size = new Size(404, 23);
            ContactEmailTextBox.TabIndex = 5;
            // 
            // ContactNameTextBox
            // 
            ContactNameTextBox.BackColor = Color.FromArgb(45, 62, 80);
            ContactNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            ContactNameTextBox.Font = new Font("Verdana", 9.75F);
            ContactNameTextBox.ForeColor = Color.White;
            ContactNameTextBox.Location = new Point(103, 384);
            ContactNameTextBox.Name = "ContactNameTextBox";
            ContactNameTextBox.Size = new Size(404, 23);
            ContactNameTextBox.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            label5.Location = new Point(103, 497);
            label5.Name = "label5";
            label5.Size = new Size(143, 16);
            label5.TabIndex = 12;
            label5.Text = "Website (optional)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            label4.Location = new Point(563, 365);
            label4.Name = "label4";
            label4.Size = new Size(54, 16);
            label4.TabIndex = 11;
            label4.Text = "Mobile";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(563, 183);
            label3.Name = "label3";
            label3.Size = new Size(113, 16);
            label3.TabIndex = 10;
            label3.Text = "Select Contact";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(53, 296);
            label8.Name = "label8";
            label8.Size = new Size(145, 23);
            label8.TabIndex = 9;
            label8.Text = "Contact Info";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 52);
            label1.Name = "label1";
            label1.Size = new Size(351, 32);
            label1.TabIndex = 8;
            label1.Text = "Contacts Management";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            label6.Location = new Point(103, 431);
            label6.Name = "label6";
            label6.Size = new Size(47, 16);
            label6.TabIndex = 14;
            label6.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            label2.Location = new Point(103, 365);
            label2.Name = "label2";
            label2.Size = new Size(49, 16);
            label2.TabIndex = 7;
            label2.Text = "Name";
            // 
            // ContactTypeComboBox
            // 
            ContactTypeComboBox.BackColor = Color.FromArgb(45, 62, 80);
            ContactTypeComboBox.FlatStyle = FlatStyle.Flat;
            ContactTypeComboBox.ForeColor = Color.White;
            ContactTypeComboBox.FormattingEnabled = true;
            ContactTypeComboBox.Location = new Point(837, 63);
            ContactTypeComboBox.MaxDropDownItems = 5;
            ContactTypeComboBox.Name = "ContactTypeComboBox";
            ContactTypeComboBox.Size = new Size(130, 24);
            ContactTypeComboBox.TabIndex = 0;
            ContactTypeComboBox.SelectedIndexChanged += ContactTypeComboBox_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(679, 66);
            label9.Name = "label9";
            label9.Size = new Size(152, 16);
            label9.TabIndex = 10;
            label9.Text = "Select Contact Type";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            label7.Location = new Point(563, 431);
            label7.Name = "label7";
            label7.Size = new Size(159, 16);
            label7.TabIndex = 11;
            label7.Text = "Telephone (optional)";
            // 
            // ContactTelephoneTextBox
            // 
            ContactTelephoneTextBox.BackColor = Color.FromArgb(45, 62, 80);
            ContactTelephoneTextBox.BorderStyle = BorderStyle.FixedSingle;
            ContactTelephoneTextBox.Font = new Font("Verdana", 9.75F);
            ContactTelephoneTextBox.ForeColor = Color.White;
            ContactTelephoneTextBox.Location = new Point(563, 450);
            ContactTelephoneTextBox.MaxLength = 9;
            ContactTelephoneTextBox.Name = "ContactTelephoneTextBox";
            ContactTelephoneTextBox.Size = new Size(404, 23);
            ContactTelephoneTextBox.TabIndex = 8;
            ContactTelephoneTextBox.KeyPress += ContactTelephoneTextBox_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            label10.Location = new Point(563, 498);
            label10.Name = "label10";
            label10.Size = new Size(111, 16);
            label10.TabIndex = 11;
            label10.Text = "Fax (optional)";
            // 
            // ContactFaxTextBox
            // 
            ContactFaxTextBox.BackColor = Color.FromArgb(45, 62, 80);
            ContactFaxTextBox.BorderStyle = BorderStyle.FixedSingle;
            ContactFaxTextBox.Font = new Font("Verdana", 9.75F);
            ContactFaxTextBox.ForeColor = Color.White;
            ContactFaxTextBox.Location = new Point(563, 517);
            ContactFaxTextBox.MaxLength = 9;
            ContactFaxTextBox.Name = "ContactFaxTextBox";
            ContactFaxTextBox.Size = new Size(404, 23);
            ContactFaxTextBox.TabIndex = 9;
            ContactFaxTextBox.KeyPress += ContactFaxTextBox_KeyPress;
            // 
            // ContactsForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(52, 73, 94);
            ClientSize = new Size(1020, 680);
            Controls.Add(SaveButton);
            Controls.Add(panel1);
            Controls.Add(ContactTypeComboBox);
            Controls.Add(ContactsComboBox);
            Controls.Add(ModifyRadioButton);
            Controls.Add(AddRadioButton);
            Controls.Add(ContactWebsiteTextBox);
            Controls.Add(ContactFaxTextBox);
            Controls.Add(ContactTelephoneTextBox);
            Controls.Add(ContactMobileTextBox);
            Controls.Add(ContactEmailTextBox);
            Controls.Add(label10);
            Controls.Add(ContactNameTextBox);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(label2);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ContactsForm";
            Padding = new Padding(50);
            Text = "ContactsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveButton;
        private Panel panel1;
        private ComboBox ContactsComboBox;
        private RadioButton ModifyRadioButton;
        private RadioButton AddRadioButton;
        private TextBox ContactWebsiteTextBox;
        private TextBox ContactMobileTextBox;
        private TextBox ContactEmailTextBox;
        private TextBox ContactNameTextBox;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label8;
        private Label label1;
        private Label label6;
        private Label label2;
        private ComboBox ContactTypeComboBox;
        private Label label9;
        private Label label7;
        private TextBox ContactTelephoneTextBox;
        private Label label10;
        private TextBox ContactFaxTextBox;
    }
}