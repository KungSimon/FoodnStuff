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
    public partial class WorkerLogIn : Form
    {
        private UserManager userManager;
        public WorkerLogIn()
        {
            InitializeComponent();
            userManager = new UserManager();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            string userName = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            foreach (User admin in userManager.Administrators)
            {
                if (admin.Username ==  userName && admin.Password == password) 
                {
                    MessageBox.Show("Log in successful");
                    //return;
                    Close();
                }
            }
            MessageBox.Show("Invalid username or password. Please try again");
        }
    }
}
