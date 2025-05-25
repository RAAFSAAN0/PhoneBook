using PhoneBook.DAL.EF.Tables;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class welcome : Form
    {
        private User _user; // store the user

        public welcome(User user)
        {
            InitializeComponent();
            _user = user; // assign it
            SetWelcomeText(_user.Username);
        }

        private void SetWelcomeText(string username)
        {
            lblText.Text = $"Hello, {username}!";
            lblText.ForeColor = Color.Blue;
            lblText.Font = new Font("Segoe UI", 18, FontStyle.Bold);
        }
    }
}
