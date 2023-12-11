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
        private UserManager userManager = UserManager.GetInstance();
        private ProductManager productManager = ProductManager.GetInstance();
        private Shipping shipping;
        public WorkerLogIn(UserManager userManager, Form1 form1, ProductManager productManager, Shipping shipping)
        {
            InitializeComponent();
            this.shipping = shipping;
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            string userName = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            bool LogInSuccess = false;

            foreach (User admin in userManager.Administrators)
            {
                if (admin.Username == userName && admin.Password == password)
                {
                    MessageBox.Show("Log in successful");
                    //return;
                    Close();
                    AdminMenu adminMenu = new AdminMenu(userManager, admin, productManager, shipping);
                    adminMenu.Show();
                    LogInSuccess = true;
                }
            }
            if (!LogInSuccess)
            {
                MessageBox.Show("Invalid username or password. Please try again");
            }
        }

        private void WorkerLogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
