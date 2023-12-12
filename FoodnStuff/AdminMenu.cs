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
        private Shipping shipping;
        private User Admin;
        private Form1 form;

        private bool _isDirty = false;
        public AdminMenu(UserManager userManager, User admin, ProductManager productManager, Shipping shipping)
        {
            InitializeComponent();
            //this.userManager = userManager;
            this.Admin = admin;
            //this.ProductManager = productManager;
            //LISTBOX NOT DONE YET!
            itemsListBox.DataSource = productManager.Inventory;
            itemsListBox.DisplayMember = "Name";

            //this.FormClosing += AdminMenu_FormClosing;
            this.shipping = shipping;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            //Här ska det sparas
            string userName = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            userManager.RegisterAdministrator(Admin, userName, password);
            MessageBox.Show("Admin registration successful!");
            usernameTextBox.Clear();
            passwordTextBox.Clear();
            var fileManager = FileManager.GetInstance();
            fileManager.SaveManagers();
        }

        private void addNewItemButton_Click(object sender, EventArgs e)
        //Här ska det sparas
        {
            NewItem newItem = new NewItem(productManager, this);
            newItem.Show();
        }

        private void removeItemButton_Click(object sender, EventArgs e)
        {
            //Här ska det det försvinna
            if (itemsListBox.SelectedItem != null)
            {
                Product selectedProduct = (Product)itemsListBox.SelectedItem;

                productManager.Inventory.Remove(selectedProduct);
                productManager.CategorySorter();

                uppdateListBox();

                MessageBox.Show("Item removed successfully!");
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }
            var fileManager = FileManager.GetInstance();
            fileManager.SaveManagers();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedItems != null)
            {

                Product selectedProduct = (Product)itemsListBox.SelectedItem;
                selectedProduct.GetInfo();

                NewItem newItem = new NewItem(selectedProduct);

                newItem.Show();
            }

        }

        private void logOutButton_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
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

                categoryTextBox.Text = selectedProduct.Category;
                nameTextBox.Text = selectedProduct.Name;
                descriptionTextBox.Text = selectedProduct.Description;
                idTextBox.Text = selectedProduct.ID.ToString();
                priceTextBox.Text = selectedProduct.Price.ToString();
                quantityTextBox.Text = selectedProduct.Quantity.ToString();
                _isDirty = false;
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
        /*private void AdminMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Stäng alla former (Forms) här
                //Funkar inte får "System.StackOverflowException"
                this.Close();
                Environment.Exit(1);
            }
        }*/


        private void chooseTransportButton_Click(object sender, EventArgs e)
        {
            Shipping shipping = new Shipping();
            shipping.Show();
        }

        public void SetForm(Form1 form)
        {
            this.form = form;
        }

        private void AdminMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            //int openForms = Application.OpenForms.Count;
            //for (int i = 0; i < openForms; i++)
            //{
            //    Application.OpenForms[i].Close();
            //}
        }


        private void editButton_Click_1(object sender, EventArgs e)
        {
            if (!_isDirty)
            {
                MessageBox.Show("No changes found");
                return;
            }
            MessageBox.Show("Successfully updated product");
            Product product = itemsListBox.SelectedItem as Product;
            if (product != null)
            {
                product.Category = categoryTextBox.Text;
                product.Name = nameTextBox.Text;
                product.Description = descriptionTextBox.Text;
                if (int.TryParse(idTextBox.Text, out int _idTextBox))
                {
                    product.ID = _idTextBox;
                }
                if (int.TryParse(priceTextBox.Text, out int _priceTextBox))
                {
                    product.Price = _priceTextBox;
                }
                if (int.TryParse(quantityTextBox.Text, out int _quantityTextBox))
                {
                    product.Quantity = _quantityTextBox;
                }
            }
            var fileManager = FileManager.GetInstance();
            fileManager.SaveManagers();
        }

        private void aTextBox_TextChanged(object sender, EventArgs e)
        {
            _isDirty = true;
        }
    }
}
