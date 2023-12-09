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
    public partial class NewItem : Form
    {
        private AdminMenu adminMenu;
        private Product product;
        private ProductManager productManager = ProductManager.GetInstance();
        public NewItem(ProductManager _productManager, AdminMenu adminMenu)
        {
            InitializeComponent();
            this.adminMenu = adminMenu;
        }

        //to be able to fill in the product information when "edit item" is selected
        public NewItem(Product product)
        {
            InitializeComponent();
            this.product = product;

            catagoryTextBox.Text = product.Category;
            itemNameTextBox.Text = product.Name;
            priceNumeric.Value = product.Price;
            quantityNumeric.Value = product.Quantity;
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            string _category = catagoryTextBox.Text;
            string _name = itemNameTextBox.Text;
            int _price;
            int _quantity;
            if (int.TryParse(priceNumeric.Text, out int inputprice))
            {
                _price = inputprice;
            }
            else
            {
                MessageBox.Show("Invalid price. Please enter a valid price number.");
            }
            if (int.TryParse(quantityNumeric.Text, out int inputQuantity))
            {
                _quantity = inputQuantity;
            }
            else
            {
                MessageBox.Show("Invalid quantity. Please enter a valid quantity number.");
            }
            productManager.CreateProduct(_category, _name, inputprice, inputQuantity);
            adminMenu.uppdateListBox();
            catagoryTextBox.Text = "";
            itemNameTextBox.Text = "";
            priceNumeric.ResetText();
            quantityNumeric.ResetText();

            // Testing filesaving
            var fm = FileManager.GetInstance();
            fm.SaveProductManager(productManager.Inventory, productManager.ProductID);
            var um = UserManager.GetInstance();
            fm.SaveUserManager(um.RegisteredCustomers, um.Administrators, um.UserID);
            var bm = BankManager.GetInstance();
            fm.SaveBankManager(bm.BankAccounts);
        }

    }
}
