using PhoneBook.Classes;
using PhoneBook.DAL.EF;
using PhoneBook.DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhoneBook.Classes;


namespace PhoneBook
{

    public partial class Manage_Contacts: Form
    {
        private PhonebookContext db = new PhonebookContext();
        private int selectedContactId = -1;
        private int selectedPhoneId = -1;



        public Manage_Contacts()
        {
            InitializeComponent();
            LoadContacts();

        }

        private void LoadContacts()
        {
            var contacts = db.Contacts.ToList()
                .Select(c => new
                {
                    c.Id,
                    c.Name,
                    c.Email,
                    c.Group,
                    PhoneCount = c.PhoneNumbers.Count
                }).ToList();

            ContactList.DataSource = contacts;
        }

        private void LoadPhoneNumbers(int contactId)
        {
            var phones = db.PhoneNumbers
                .Where(p => p.ContactId == contactId)
                .Select(p => new
                {
                    p.Id,
                    p.Number,
                    p.Type
                }).ToList();

            PhoneList.DataSource = phones;
        }


        private void Addpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = ofd.FileName;
                    string imageFolder = Path.Combine(Application.StartupPath, "Images");
                    Directory.CreateDirectory(imageFolder);

                    string fileName = Path.GetFileName(selectedPath);
                    string destPath = Path.Combine(imageFolder, fileName);

                    File.Copy(selectedPath, destPath, true);

                    picProfile.Image = Image.FromFile(destPath);
                    picProfile.Tag = destPath;
                }
            }


        }

        private void PhoneList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }






        private void ContactList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ContactList.Rows[e.RowIndex];
                selectedContactId = Convert.ToInt32(row.Cells["Id"].Value);
                var contact = db.Contacts.FirstOrDefault(c => c.Id == selectedContactId);
                if (contact != null)
                {
                    txtName.Text = contact.Name;
                    txtEmail.Text = contact.Email;
                    txtAddress.Text = contact.Address;
                    comboGroup.SelectedItem = contact.Group;

                    if (!string.IsNullOrEmpty(contact.ProfilePhotoPath) && File.Exists(contact.ProfilePhotoPath))
                    {
                        picProfile.Image = Image.FromFile(contact.ProfilePhotoPath);
                        picProfile.Tag = contact.ProfilePhotoPath;
                    }

                    LoadPhoneNumbers(selectedContactId);
                }
            }




        }

        private void PhoneLIst_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = PhoneList.Rows[e.RowIndex];
                selectedPhoneId = Convert.ToInt32(row.Cells["Id"].Value);
                txtPhone.Text = row.Cells["Number"].Value.ToString();
                comboType.SelectedItem = row.Cells["Type"].Value.ToString();
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedContactId == -1)
            {
                MessageBox.Show("Select a contact to edit.");
                return;
            }

            var contact = db.Contacts.FirstOrDefault(c => c.Id == selectedContactId);
            if (contact != null)
            {
                contact.Name = txtName.Text.Trim();
                contact.Email = txtEmail.Text.Trim();
                contact.Address = txtAddress.Text.Trim();
                contact.Group = comboGroup.SelectedItem?.ToString();
                contact.ProfilePhotoPath = picProfile.Tag?.ToString();
                db.SaveChanges();
                MessageBox.Show("Contact updated.");
                LoadContacts();
            }

            if (selectedPhoneId != -1)
            {
                var phone = db.PhoneNumbers.FirstOrDefault(p => p.Id == selectedPhoneId);
                if (phone != null)
                {
                    phone.Number = txtPhone.Text.Trim();
                    phone.Type = comboType.SelectedItem?.ToString();
                    db.SaveChanges();
                    LoadPhoneNumbers(selectedContactId);
                    MessageBox.Show("Phone number updated.");
                    selectedPhoneId = -1;
                }
            }

        }

        private void btnSaveContact_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPhone.Text) || comboGroup.SelectedItem == null || comboType.SelectedItem == null)
            {
                MessageBox.Show("Name, phone, group, and phone type are required.");
                return;
            }

            Contact contact = new Contact
            {
                Name = txtName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                Group = comboGroup.SelectedItem.ToString(),
                ProfilePhotoPath = picProfile.Tag?.ToString(),
                UserId = Session.CurrentUserId
            };

            db.Contacts.Add(contact);
            db.SaveChanges();

            PhoneNumber number = new PhoneNumber
            {
                ContactId = contact.Id,
                Number = txtPhone.Text.Trim(),
                Type = comboType.SelectedItem.ToString()
            };

            db.PhoneNumbers.Add(number);
            db.SaveChanges();

            MessageBox.Show("Contact saved successfully.");
            ClearForm();
            LoadContacts();
        }

        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            if (selectedContactId == -1)
            {
                MessageBox.Show("Please select a contact to add a phone number.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text) || comboType.SelectedItem == null)
            {
                MessageBox.Show("Phone number and type are required.");
                return;
            }

            PhoneNumber number = new PhoneNumber
            {
                ContactId = selectedContactId,
                Number = txtPhone.Text.Trim(),
                Type = comboType.SelectedItem.ToString()
            };

            db.PhoneNumbers.Add(number);
            db.SaveChanges();

            LoadPhoneNumbers(selectedContactId);
            LoadContacts();
            txtPhone.Clear();
            comboType.SelectedIndex = -1;
        }

        private void ClearForm()
        {
            txtName.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            comboGroup.SelectedIndex = -1;
            txtPhone.Clear();
            comboType.SelectedIndex = -1;
            picProfile.Image = null;
            picProfile.Tag = null;
            selectedContactId = -1;
            selectedPhoneId = -1;
            PhoneList.DataSource = null;
        }

       
    }
}
