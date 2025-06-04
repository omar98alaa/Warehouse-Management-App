using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse_Management_App.Entities;

namespace Warehouse_Management_App.Forms
{
    public partial class ContactsForm : Form
    {
        //
        //  Fields
        //
        AppDbContext m_appDbContext = new AppDbContext();
        List<Contact> m_contacts;
        string m_emailPattern = @"(@)(.+)$";
        string m_mobilePattern = @"^01[0-2 | 5][0-9]{8}$";
        string m_telephonePattern = @"^0[0-9]{7}$";


        //
        //  Constructors
        //
        public ContactsForm()
        {
            InitializeComponent();

            // Disable contacts combo box while add new is selected
            ContactsComboBox.Enabled = !AddRadioButton.Checked;

            // Add contacts options and select supplier by default
            ContactTypeComboBox.Items.AddRange([ContactType.Supplier, ContactType.Client]);
            ContactTypeComboBox.SelectedIndex = 0;
        }


        //
        //  Mehtods
        //
        void LoadContactsList()
        {
            // Create new context
            m_appDbContext = new AppDbContext();

            // Get the selected contact type
            var contactType = (ContactType)ContactTypeComboBox.SelectedItem;

            // Load the corresponding contacts
            m_contacts = (from C in m_appDbContext.Contacts where C.Type == contactType orderby C.Name select C).ToList();

            // Set contacts combo box datasource
            ContactsComboBox.DataSource = (from C in m_contacts select C.Email).ToList();
            ContactsComboBox.SelectedIndex = -1;
            ContactsComboBox.ResetText();
        }

        void ClearInputFields()
        {
            ContactNameTextBox.Text = "";
            ContactEmailTextBox.Text = "";
            ContactWebsiteTextBox.Text = "";
            ContactMobileTextBox.Text = "";
            ContactTelephoneTextBox.Text = "";
            ContactFaxTextBox.Text = "";
        }



        //
        //  Event handlers
        //
        private void ContactMobileTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow numbers and backspace only
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void ContactTelephoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow numbers and backspace only
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void ContactFaxTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow numbers and backspace only
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void AddRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle contacts combo box enabled state
            ContactsComboBox.Enabled = !AddRadioButton.Checked;

            if (AddRadioButton.Checked)
            {
                // Clear input fields in case of add new
                ClearInputFields();
            }
            else if (m_contacts == null)
            {
                // Load contacts if not loaded in case of modify
                LoadContactsList();
            }
        }

        private void ContactTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Reload contacts when type changed
            LoadContactsList();
            ClearInputFields();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Input validation
                if (!Regex.IsMatch(ContactEmailTextBox.Text, m_emailPattern))
                {
                    throw new ApplicationException("Invalid Email");
                }
                else if (!Regex.IsMatch(ContactMobileTextBox.Text, m_mobilePattern))
                {
                    throw new ApplicationException("Invalid Mobile");
                }
                else if (ContactTelephoneTextBox.Text != "" && !Regex.IsMatch(ContactTelephoneTextBox.Text, m_telephonePattern))
                {
                    throw new ApplicationException("Invalid Telephone");
                }
                else if (ContactFaxTextBox.Text != "" && !Regex.IsMatch(ContactFaxTextBox.Text, m_telephonePattern))
                {
                    throw new ApplicationException("Invalid Fax");
                }


                Contact contact;

                // Check if this is a new contact or modifying an existing one
                if (AddRadioButton.Checked)
                {
                    contact = new Contact();
                    contact.Type = (ContactType)ContactTypeComboBox.SelectedItem;
                }
                else
                {
                    var idx = ContactsComboBox.SelectedIndex;
                    contact = m_contacts[idx];
                }

                // Set contact properties
                contact.Name = ContactNameTextBox.Text;
                contact.Email = ContactEmailTextBox.Text;
                contact.Mobile = ContactMobileTextBox.Text;
                contact.Telephone = ContactTelephoneTextBox.Text;
                contact.Fax = ContactFaxTextBox.Text;
                contact.Website = ContactWebsiteTextBox.Text;

                // Update contact if exists, add it if no primary key provide it
                m_appDbContext.Contacts.Update(contact);

                // Save changes to DB
                m_appDbContext.SaveChanges();

                MessageBox.Show("Contact saved successfully");

                // Reload contacts list
                LoadContactsList();
            }
            catch (ApplicationException E)
            {
                MessageBox.Show(E.Message);
            }
            catch(Exception E)
            {
                MessageBox.Show("Failed to save contact");
            }
        }

        private void ContactsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Fill the input fields with the selected contact's info
            if (ContactsComboBox.SelectedIndex != -1)
            {
                int idx = ContactsComboBox.SelectedIndex;

                ContactNameTextBox.Text = m_contacts[idx].Name;
                ContactEmailTextBox.Text = m_contacts[idx].Email;
                ContactMobileTextBox.Text = m_contacts[idx].Mobile;
                ContactTelephoneTextBox.Text = m_contacts[idx].Telephone;
                ContactFaxTextBox.Text = m_contacts[idx].Fax;
                ContactWebsiteTextBox.Text = m_contacts[idx].Website;
            }
            else
            {
                // Clear if non is selected
                ClearInputFields();
            }
        }
    }
}
