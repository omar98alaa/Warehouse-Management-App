namespace Warehouse_Management_App
{
    public partial class Form1 : Form
    {
        //
        //  Fields
        //
        Button m_activeButton;
        Form m_activeForm;


        //
        //  Constructors
        //
        public Form1()
        {
            InitializeComponent();

            // Set active form to dashborad
            ActivateFormButton(DashboardFormButton);
            ChangeMainForm(new Forms.DashboardForm());
        }


        //
        //  Methods
        //
        void ActivateFormButton(Button clickedButton)
        {
            // Make loading label visible
            LoadingLabel.Visible = true;

            // Make the current active button style default
            if (m_activeButton != null)
            {
                m_activeButton.ForeColor = Color.White;
            }

            // Set the active button to the clicked button
            m_activeButton = clickedButton;

            // Set the active button style
            m_activeButton.ForeColor = ActiveButtonSideMarker.BackColor;

            // Move the side marker to match the active button
            ActiveButtonSideMarker.Top = m_activeButton.Top;

            // Force the UI to render before blocking
            Application.DoEvents();
        }

        void ChangeMainForm(Form newForm)
        {
            // Close the currently active form
            if (m_activeForm != null)
            {
                m_activeForm.Close();
            }

            // Set the active form to the selected one
            m_activeForm = newForm;

            // Set the active form properties and display it in the main panel
            m_activeForm.TopLevel = false;
            m_activeForm.Top = 0;
            m_activeForm.Left = 0;
            m_activeForm.FormBorderStyle = FormBorderStyle.None;
            m_activeForm.BackColor = MainFormPanel.BackColor;

            MainFormPanel.Controls.Add(m_activeForm);
            MainFormPanel.Tag = m_activeForm;

            m_activeForm.BringToFront();
            m_activeForm.Show();

            // Hide the loading label
            LoadingLabel.Visible = false;
        }



        //
        //  Event handlers
        //
        private void DashboardFormButton_Click(object sender, EventArgs e)
        {
            if (m_activeButton != DashboardFormButton)
            {
                ActivateFormButton(DashboardFormButton);
                ChangeMainForm(new Forms.DashboardForm());
            }
        }

        private void WarehousesFormButton_Click(object sender, EventArgs e)
        {
            if (m_activeButton != WarehousesFormButton)
            {
                ActivateFormButton(WarehousesFormButton);
                ChangeMainForm(new Forms.WarehousesForm());
            }
        }

        private void ProductsFormButton_Click(object sender, EventArgs e)
        {
            if (m_activeButton != ProductsFormButton)
            {
                ActivateFormButton(ProductsFormButton);
                ChangeMainForm(new Forms.ProductsForm());
            }
        }

        private void ContactsFormButton_Click(object sender, EventArgs e)
        {
            if (m_activeButton != ContactsFormButton)
            {
                ActivateFormButton(ContactsFormButton);
                ChangeMainForm(new Forms.ContactsForm());
            }
        }

        private void ImportsFormButton_Click(object sender, EventArgs e)
        {
            if (m_activeButton != ImportsFormButton)
            {
                ActivateFormButton(ImportsFormButton);
                ChangeMainForm(new Forms.ImportsForm());
            }
        }

        private void ExportsFormButton_Click(object sender, EventArgs e)
        {
            if (m_activeButton != ExportsFormButton)
            {
                ActivateFormButton(ExportsFormButton);
                ChangeMainForm(new Forms.ExportsForm());
            }
        }

        private void TransfersFormButton_Click(object sender, EventArgs e)
        {
            if (m_activeButton != TransfersFormButton)
            {
                ActivateFormButton(TransfersFormButton);
                ChangeMainForm(new Forms.TransfersForm());
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
