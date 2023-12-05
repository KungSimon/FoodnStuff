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
    public partial class WorkerLogIn : Form
    {
        private UserManager userManager = UserManager.GetInstance();
        private ProductManager productManager = ProductManager.GetInstance();
        private ChooseTransport chooseTransport;
        public WorkerLogIn(UserManager userManager, Form1 form1, ProductManager productManager, ChooseTransport chooseTransport)
        {
            InitializeComponent();
            this.chooseTransport = chooseTransport;
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
                    AdminMenu adminMenu = new AdminMenu(userManager, admin, productManager, chooseTransport);
                    adminMenu.Show();
                    LogInSuccess = true;
                }
            }
            if (!LogInSuccess)
            {
                MessageBox.Show("Invalid username or password. Please try again");
            }
        }
    }
}
