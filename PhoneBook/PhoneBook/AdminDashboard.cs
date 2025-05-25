using PhoneBook.DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class AdminDashboard: Form
    {
        private User _loggedInUser;

        public AdminDashboard(User user)
        {
            InitializeComponent();
            _loggedInUser = user;

            this.Text = $"Admin Panel - {user.Username}";
        }
    }
}
