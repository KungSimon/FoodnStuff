﻿using System;
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
        private UserManager userManager;
        public RegisterUser()
        {
            InitializeComponent();
            userManager = new UserManager();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string userName = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string address = addressTextBox.Text;

            userManager.RegisterCustomer(name, userName, password, address);
            MessageBox.Show("Registration successful!");
            Close();
        }
    }
}