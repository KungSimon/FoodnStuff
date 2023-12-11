using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Payment : Form
    {
        Form1 form1;
        UserManager userManager = UserManager.GetInstance();
        BankManager bankManager = BankManager.GetInstance();
        FileManager fileManager = FileManager.GetInstance();
        //private int totalCost;
         
        public Payment(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
            purchaseButton.Click += purchaseButton_Click;
            nameTextBox.Text = userManager.CurrentUser.Name;
            addressTextBox.Text = userManager.CurrentUser.Address;
            //this.totalCost = totalCost;
        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            //if (userManager.CurrentUser != null)
            //{
            //    nameTextBox.Text = userManager.CurrentUser.Name;
            //    addressTextBox.Text = userManager.CurrentUser.Address;
            //}
            if (nameTextBox.Text == "" && addressTextBox.Text == "")
            {
                MessageBox.Show("Please write name and address to make a purchase");
                return;
            }
            if (!bankManager.TryLogin(cardNumberTextBox.Text, cardPinTextBox.Text))
            {
                return;
            }
           
            bankManager.Pay(form1.currentCart.CalculateCartTotal());
            fileManager.SaveBankManager(bankManager.BankAccounts);
            // Convert to Order
            ProductManager productManager = ProductManager.GetInstance();
            productManager.CartToOrder(form1.currentCart, addressTextBox.Text, nameTextBox.Text);
            form1.currentCart = new Cart();
            if (userManager.CurrentUser != null)
            {
                userManager.CurrentUser.MyCart.ProductsInCart = new List<Product>();
            }
            MessageBox.Show($"Order with {form1.currentCart.ProductsInCart.Count()} items has been placed to {nameTextBox.Text} at {nameTextBox.Text}");
        }


        private void cardNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cardPinTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
