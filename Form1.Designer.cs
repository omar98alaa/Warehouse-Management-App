namespace Warehouse_Management_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            ExitButton = new Button();
            ActiveButtonSideMarker = new Panel();
            TransfersFormButton = new Button();
            ExportsFormButton = new Button();
            ImportsFormButton = new Button();
            ContactsFormButton = new Button();
            ProductsFormButton = new Button();
            WarehousesFormButton = new Button();
            DashboardFormButton = new Button();
            panel3 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            LoadingLabel = new Label();
            MainFormPanel = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 62, 80);
            panel1.Controls.Add(ExitButton);
            panel1.Controls.Add(ActiveButtonSideMarker);
            panel1.Controls.Add(TransfersFormButton);
            panel1.Controls.Add(ExportsFormButton);
            panel1.Controls.Add(ImportsFormButton);
            panel1.Controls.Add(ContactsFormButton);
            panel1.Controls.Add(ProductsFormButton);
            panel1.Controls.Add(WarehousesFormButton);
            panel1.Controls.Add(DashboardFormButton);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 720);
            panel1.TabIndex = 0;
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.None;
            ExitButton.BackColor = Color.Transparent;
            ExitButton.FlatAppearance.BorderSize = 0;
            ExitButton.FlatAppearance.MouseDownBackColor = Color.DarkRed;
            ExitButton.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.Location = new Point(0, 605);
            ExitButton.Margin = new Padding(2, 3, 2, 3);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(260, 55);
            ExitButton.TabIndex = 9;
            ExitButton.Text = "EXIT";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // ActiveButtonSideMarker
            // 
            ActiveButtonSideMarker.BackColor = Color.FromArgb(27, 188, 155);
            ActiveButtonSideMarker.Location = new Point(0, 126);
            ActiveButtonSideMarker.Margin = new Padding(2, 3, 2, 3);
            ActiveButtonSideMarker.Name = "ActiveButtonSideMarker";
            ActiveButtonSideMarker.Size = new Size(10, 55);
            ActiveButtonSideMarker.TabIndex = 2;
            // 
            // TransfersFormButton
            // 
            TransfersFormButton.BackColor = Color.Transparent;
            TransfersFormButton.Dock = DockStyle.Top;
            TransfersFormButton.FlatAppearance.BorderSize = 0;
            TransfersFormButton.FlatAppearance.CheckedBackColor = Color.FromArgb(52, 73, 94);
            TransfersFormButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 73, 94);
            TransfersFormButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 73, 94);
            TransfersFormButton.FlatStyle = FlatStyle.Flat;
            TransfersFormButton.Font = new Font("Verdana", 12F);
            TransfersFormButton.Location = new Point(0, 456);
            TransfersFormButton.Margin = new Padding(2, 3, 2, 3);
            TransfersFormButton.Name = "TransfersFormButton";
            TransfersFormButton.Size = new Size(260, 55);
            TransfersFormButton.TabIndex = 8;
            TransfersFormButton.Text = "TRANSFERS";
            TransfersFormButton.UseVisualStyleBackColor = false;
            TransfersFormButton.Click += TransfersFormButton_Click;
            // 
            // ExportsFormButton
            // 
            ExportsFormButton.BackColor = Color.Transparent;
            ExportsFormButton.Dock = DockStyle.Top;
            ExportsFormButton.FlatAppearance.BorderSize = 0;
            ExportsFormButton.FlatAppearance.CheckedBackColor = Color.FromArgb(52, 73, 94);
            ExportsFormButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 73, 94);
            ExportsFormButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 73, 94);
            ExportsFormButton.FlatStyle = FlatStyle.Flat;
            ExportsFormButton.Font = new Font("Verdana", 12F);
            ExportsFormButton.Location = new Point(0, 401);
            ExportsFormButton.Margin = new Padding(2, 3, 2, 3);
            ExportsFormButton.Name = "ExportsFormButton";
            ExportsFormButton.Size = new Size(260, 55);
            ExportsFormButton.TabIndex = 7;
            ExportsFormButton.Text = "EXPORTS";
            ExportsFormButton.UseVisualStyleBackColor = false;
            ExportsFormButton.Click += ExportsFormButton_Click;
            // 
            // ImportsFormButton
            // 
            ImportsFormButton.BackColor = Color.Transparent;
            ImportsFormButton.Dock = DockStyle.Top;
            ImportsFormButton.FlatAppearance.BorderSize = 0;
            ImportsFormButton.FlatAppearance.CheckedBackColor = Color.FromArgb(52, 73, 94);
            ImportsFormButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 73, 94);
            ImportsFormButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 73, 94);
            ImportsFormButton.FlatStyle = FlatStyle.Flat;
            ImportsFormButton.Font = new Font("Verdana", 12F);
            ImportsFormButton.Location = new Point(0, 346);
            ImportsFormButton.Margin = new Padding(2, 3, 2, 3);
            ImportsFormButton.Name = "ImportsFormButton";
            ImportsFormButton.Size = new Size(260, 55);
            ImportsFormButton.TabIndex = 6;
            ImportsFormButton.Text = "IMPORTS";
            ImportsFormButton.UseVisualStyleBackColor = false;
            ImportsFormButton.Click += ImportsFormButton_Click;
            // 
            // ContactsFormButton
            // 
            ContactsFormButton.BackColor = Color.Transparent;
            ContactsFormButton.Dock = DockStyle.Top;
            ContactsFormButton.FlatAppearance.BorderSize = 0;
            ContactsFormButton.FlatAppearance.CheckedBackColor = Color.FromArgb(52, 73, 94);
            ContactsFormButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 73, 94);
            ContactsFormButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 73, 94);
            ContactsFormButton.FlatStyle = FlatStyle.Flat;
            ContactsFormButton.Font = new Font("Verdana", 12F);
            ContactsFormButton.Location = new Point(0, 291);
            ContactsFormButton.Margin = new Padding(2, 3, 2, 3);
            ContactsFormButton.Name = "ContactsFormButton";
            ContactsFormButton.Size = new Size(260, 55);
            ContactsFormButton.TabIndex = 5;
            ContactsFormButton.Text = "CONTACTS";
            ContactsFormButton.UseVisualStyleBackColor = false;
            ContactsFormButton.Click += ContactsFormButton_Click;
            // 
            // ProductsFormButton
            // 
            ProductsFormButton.BackColor = Color.Transparent;
            ProductsFormButton.Dock = DockStyle.Top;
            ProductsFormButton.FlatAppearance.BorderSize = 0;
            ProductsFormButton.FlatAppearance.CheckedBackColor = Color.FromArgb(52, 73, 94);
            ProductsFormButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 73, 94);
            ProductsFormButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 73, 94);
            ProductsFormButton.FlatStyle = FlatStyle.Flat;
            ProductsFormButton.Font = new Font("Verdana", 12F);
            ProductsFormButton.Location = new Point(0, 236);
            ProductsFormButton.Margin = new Padding(2, 3, 2, 3);
            ProductsFormButton.Name = "ProductsFormButton";
            ProductsFormButton.Size = new Size(260, 55);
            ProductsFormButton.TabIndex = 4;
            ProductsFormButton.Text = "PRODUCTS";
            ProductsFormButton.UseVisualStyleBackColor = false;
            ProductsFormButton.Click += ProductsFormButton_Click;
            // 
            // WarehousesFormButton
            // 
            WarehousesFormButton.BackColor = Color.Transparent;
            WarehousesFormButton.Dock = DockStyle.Top;
            WarehousesFormButton.FlatAppearance.BorderSize = 0;
            WarehousesFormButton.FlatAppearance.CheckedBackColor = Color.FromArgb(52, 73, 94);
            WarehousesFormButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 73, 94);
            WarehousesFormButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 73, 94);
            WarehousesFormButton.FlatStyle = FlatStyle.Flat;
            WarehousesFormButton.Font = new Font("Verdana", 12F);
            WarehousesFormButton.Location = new Point(0, 181);
            WarehousesFormButton.Margin = new Padding(2, 3, 2, 3);
            WarehousesFormButton.Name = "WarehousesFormButton";
            WarehousesFormButton.Size = new Size(260, 55);
            WarehousesFormButton.TabIndex = 3;
            WarehousesFormButton.Text = "WAREHOUSES";
            WarehousesFormButton.UseVisualStyleBackColor = false;
            WarehousesFormButton.Click += WarehousesFormButton_Click;
            // 
            // DashboardFormButton
            // 
            DashboardFormButton.BackColor = Color.Transparent;
            DashboardFormButton.Dock = DockStyle.Top;
            DashboardFormButton.FlatAppearance.BorderSize = 0;
            DashboardFormButton.FlatAppearance.CheckedBackColor = Color.FromArgb(52, 73, 94);
            DashboardFormButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 73, 94);
            DashboardFormButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 73, 94);
            DashboardFormButton.FlatStyle = FlatStyle.Flat;
            DashboardFormButton.Font = new Font("Verdana", 12F);
            DashboardFormButton.ForeColor = Color.White;
            DashboardFormButton.Location = new Point(0, 126);
            DashboardFormButton.Margin = new Padding(2, 3, 2, 3);
            DashboardFormButton.Name = "DashboardFormButton";
            DashboardFormButton.Size = new Size(260, 55);
            DashboardFormButton.TabIndex = 2;
            DashboardFormButton.Text = "DASHBOARD";
            DashboardFormButton.UseVisualStyleBackColor = false;
            DashboardFormButton.Click += DashboardFormButton_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(260, 126);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(260, 126);
            label1.TabIndex = 0;
            label1.Text = "WAREHOUSE\r\nMANAGER";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(45, 62, 80);
            panel2.Controls.Add(LoadingLabel);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(260, 0);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1020, 40);
            panel2.TabIndex = 1;
            // 
            // LoadingLabel
            // 
            LoadingLabel.AutoSize = true;
            LoadingLabel.Location = new Point(475, 12);
            LoadingLabel.Margin = new Padding(2, 0, 2, 0);
            LoadingLabel.Name = "LoadingLabel";
            LoadingLabel.Size = new Size(78, 17);
            LoadingLabel.TabIndex = 2;
            LoadingLabel.Text = "Loading...";
            LoadingLabel.TextAlign = ContentAlignment.MiddleCenter;
            LoadingLabel.Visible = false;
            // 
            // MainFormPanel
            // 
            MainFormPanel.AutoScroll = true;
            MainFormPanel.Dock = DockStyle.Top;
            MainFormPanel.Location = new Point(260, 40);
            MainFormPanel.Name = "MainFormPanel";
            MainFormPanel.Size = new Size(1020, 680);
            MainFormPanel.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(52, 73, 94);
            ClientSize = new Size(1280, 720);
            Controls.Add(MainFormPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Warehouse Manager";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Label LoadingLabel;
        private Button DashboardFormButton;
        private Button TransfersFormButton;
        private Button ExportsFormButton;
        private Button ImportsFormButton;
        private Button ContactsFormButton;
        private Button ProductsFormButton;
        private Button WarehousesFormButton;
        private Panel ActiveButtonSideMarker;
        private Button ExitButton;
        private Panel MainFormPanel;
    }
}
