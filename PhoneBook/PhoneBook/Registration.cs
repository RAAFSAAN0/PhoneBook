using PhoneBook.DAL.EF.Tables;
using PhoneBook.DAL.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace PhoneBook
{
    public partial class Registration: Form
    {
        private ToolTip errorTip = new ToolTip();
        public Registration()
        {
            InitializeComponent();
            ClearErrors();
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            ClearErrors(); // Reset previous styles

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string confirm = txtConfirm.Text;

            // Empty field validation
            if (string.IsNullOrEmpty(username))
            {
                SetError(txtUsername, "Username is required.");
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                SetError(txtPassword, "Password is required.");
                return;
            }
            if (string.IsNullOrEmpty(confirm))
            {
                SetError(txtConfirm, "Please confirm your password.");
                return;
            }

            // Password match validation
            if (password != confirm)
            {
                SetError(txtConfirm, "Passwords do not match.");
                return;
            }

            // Check for existing username
            using (var db = new PhonebookContext())
            {
                if (db.Users.Any(u => u.Username == username))
                {
                    SetError(txtUsername, "Username already exists.");
                    return;
                }

                // All good: add user
                db.Users.Add(new User
                {
                    Username = username,
                    PasswordHash = password, // In real apps, hash this!
                    IsAdmin = false
                });
                db.SaveChanges();

                MessageBox.Show("Registration successful! You may now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                new Login_Form().Show();
            }

        }

       

        private void SetError(Guna2TextBox box, string message)
        {
            box.FillColor = Color.MistyRose;
            errorTip.ToolTipTitle = "Input Error";
            errorTip.Show(message, box, 0, -40, 3000);
        }


        private void ClearErrors()
        {
            txtUsername.BackColor = SystemColors.Window;
            txtPassword.BackColor = SystemColors.Window;
            txtConfirm.BackColor = SystemColors.Window;
            errorTip.RemoveAll();
        }

        private void checkShowPassword_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
