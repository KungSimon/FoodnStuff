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
        //Form1 form1;
        private UserManager userManager = UserManager.GetInstance();
        private ProductManager productManager = ProductManager.GetInstance();
        //private UserManager userManager;
        private User Admin;
        //private ProductManager ProductManager;
        public AdminMenu(UserManager userManager, User admin, ProductManager productManager)
        {
            InitializeComponent();
            //this.userManager = userManager;
            this.Admin = admin;
            //this.ProductManager = productManager;
            //LISTBOX NOT DONE YET!
            itemsListBox.DataSource = productManager.Inventory;
            itemsListBox.DisplayMember = "Name";
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

        private void addNewItemButton_Click(object sender, EventArgs e)
        {
            NewItem newItem = new NewItem(productManager, this);
            newItem.Show();
        }

        private void removeItemButton_Click(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedItem != null)
            {
                Product selectedProduct = (Product)itemsListBox.SelectedItem;

                productManager.Inventory.Remove(selectedProduct);

                uppdateListBox();

                MessageBox.Show("Item removed successfully!");
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            //Close();
            //form1.Visible = true;
            //form1.Show();

            //Not working yet
        }

        private void itemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedItem != null)
            {
                Product selectedProduct = (Product)itemsListBox.SelectedItem;
                itemLabel.Visible = true;
                itemLabel.Text = selectedProduct.GetInfo();
            }
            else
            {
                itemLabel.Visible = false;
            }
        }
        public void uppdateListBox()
        {
            itemsListBox.DataSource = null;
            itemsListBox.DataSource = productManager.Inventory;
            itemsListBox.DisplayMember = "Name";
        }
    }
}
