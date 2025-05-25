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
using System.Drawing;
using System;
using System.Collections.Generic;

namespace PhoneBook
{
    public partial class UserDashboard: Form
    {
        private User _loggedInUser;
        public UserDashboard(User user)
        {
            InitializeComponent();
            _loggedInUser = user;

            // Optional: display welcome message or user info

            loadform(new welcome(_loggedInUser));


        }

        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void btnShowContacts_Click(object sender, EventArgs e)
        {
            loadform(new Show_Contacts());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            loadform(new Manage_Contacts());
        }
    }
}
