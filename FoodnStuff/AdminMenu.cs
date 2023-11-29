using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodnStuff
{
    public partial class AdminMenu : Form
    {
        private UserManager userManager;
        private User Admin; 
        public AdminMenu(UserManager userManager, User admin)
        {
            InitializeComponent();
            this.userManager = userManager;
            this.Admin = admin;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string userName = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            userManager.RegisterAdministrator(Admin, userName, password);
            MessageBox.Show("Admin registration successful!");
            usernameTextBox.Clear();
            passwordTextBox.Clear();
        }
    }
}
