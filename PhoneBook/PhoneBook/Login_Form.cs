using Guna.UI2.WinForms;
using PhoneBook.DAL.EF;
using PhoneBook.DAL.EF.Tables;
using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PhoneBook.Classes;


namespace PhoneBook
{
    public partial class Login_Form : Form
    {
        private ToolTip errorTip = new ToolTip();
        public Login_Form()
        {
            InitializeComponent();
            ClearErrors();

            txtPassword.UseSystemPasswordChar = true;
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            // Optional: focus on username field on form load
            txtUsername.Focus();
        }



        private void btnLogin_Click_1(object sender, EventArgs e)
        {

            ClearErrors();

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

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

            using (var db = new PhonebookContext())
            {
                var user = db.Users
                             .Include(u => u.Contacts)
                             .FirstOrDefault(u => u.Username == username && u.PasswordHash == password);

                if (user != null)
                {

                    Session.CurrentUserId = user.Id;
                    Session.Username = user.Username;
                    MessageBox.Show($"Welcome, {user.Username}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                    if (user.IsAdmin)
                    {
                        var admin = new AdminDashboard(user);
                        admin.Show();
                    }
                    else
                    {
                        var dashboard = new UserDashboard(user);
                        dashboard.Show();
                    }
                }
                else
                {
                    SetError(txtUsername, "Invalid username or password.");
                    SetError(txtPassword, "Invalid username or password.");
                }

            }
        }

        private void lblRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var reg = new Registration();
            reg.Show();
            this.Hide();

        }

        private void SetError(Guna2TextBox box, string message)
        {
            box.FillColor = Color.MistyRose;
            errorTip.ToolTipTitle = "Login Error";
            errorTip.Show(message, box, 0, -40, 3000);
        }

        private void ClearErrors()
        {
            txtUsername.FillColor = Color.White;
            txtPassword.FillColor = Color.White;
            errorTip.RemoveAll();
        }

        private void checkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !checkShowPassword.Checked;
        }
    }
}
