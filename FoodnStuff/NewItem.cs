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
        private ProductManager productManager = ProductManager.GetInstance();
        public NewItem(ProductManager _productManager, AdminMenu adminMenu)
        {
            InitializeComponent();
            this.adminMenu = adminMenu;
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
        }

    }
}
