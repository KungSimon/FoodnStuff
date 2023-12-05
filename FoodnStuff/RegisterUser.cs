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
    public partial class RegisterUser : Form
    {
        private UserManager userManager = UserManager.GetInstance();
        public RegisterUser(UserManager userManager)
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            //Här ska det sparas
            string name = nameTextBox.Text;
            string userName = usernameTextBox.Text;
            string address = addressTextBox.Text;
            string password = passwordTextBox.Text;


            userManager.RegisterCustomer(name, userName, address, password);
            MessageBox.Show("Registration successful!");
            Close();
        }
    }
}
