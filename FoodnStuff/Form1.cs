using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FoodnStuff
{
    public partial class Form1 : Form
    {
        private Cart currentCart = new Cart();
        private Payment payment;
        private Shipping shipping;
        private UserManager userManager = UserManager.GetInstance();
        private ProductManager productManager = ProductManager.GetInstance();
        private FileManager fileManager = FileManager.GetInstance();
        public Form1()
        {
            InitializeComponent();

            this.payment = new Payment();
            this.FormClosing += Form1_FormClosing;
            this.shipping = new Shipping();
            //MessageBox.Show("Got here 0");
            fileManager.LoadManagers();
            productManager.CategorySorter();

            // Binding listbox
            //catagoryListBox.DataSource = productManager.Inventory;
            catagoryListBox.DisplayMember = "Name";
            catagoryListBox.DataSource = new BindingSource(productManager.CategoryDictionary.Keys, null);
            itemsListBox.DataSource = new BindingSource(productManager.CategoryDictionary, null);
            cartListBox.DisplayMember = "Name";
            cartListBox.DataSource = new BindingSource(currentCart.ProductsInCart, null);
        }



        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterUser registerUser = new RegisterUser(userManager);
            registerUser.Show();
        }

        private void logInWorkerButton_Click(object sender, EventArgs e)
        {
            WorkerLogIn workerLogIn = new WorkerLogIn(userManager, this, productManager, shipping);

            workerLogIn.Show();
            Hide();

        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            string userName = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            foreach (User user in userManager.RegisteredCustomers)
            {
                if (user.Username == userName && user.Password == password)
                {
                    MessageBox.Show("Log in successful");
                    usernameTextBox.Text = "";
                    passwordTextBox.Text = "";
                    usernameLabel.Visible = false;
                    passwordLabel.Visible = false;
                    usernameTextBox.Visible = false;
                    passwordTextBox.Visible = false;
                    logInButton.Visible = false;
                    logOutButton.Visible = true;
                    logOutButton.Location = new Point(440, 202);
                    logOutButton.Size = new Size(150, 75);
                    //currentCart = user.MyCart;
                    user.MyCart.MergeCart(currentCart);
                    currentCart = user.MyCart;
                    UpdateTotalCostLabel();
                    return;
                }
            }
            MessageBox.Show("Invalid username or password. Please try again");
            passwordTextBox.Text = "";
        }

        private void catagoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (catagoryListBox.SelectedIndex >= 0 && productManager.CategoryDictionary.Count > 0)
            {
                string selectedCategory = catagoryListBox.SelectedItem.ToString();
                itemsListBox.DataSource = new BindingSource(productManager.CategoryDictionary[selectedCategory], null);
                itemsListBox.DisplayMember = "Name";
                itemsListBox.Visible = true;
            }
            /*catagoryListBox.SelectedIndexChanged += (sender, args) =>
            {
                if (catagoryListBox.SelectedIndex >= 0)
                {
                    //MessageBox.Show($"This is the type{(catagoryListBox.SelectedItem).GetType().ToString()}");
                    string key;
                    if (catagoryListBox.SelectedItem is Product)
                    {
                        Product item = (Product)catagoryListBox.SelectedItem;
                        key = item.Category;
                    }
                    else
                    {
                        key = catagoryListBox.SelectedItem.ToString();
                    }
                    cartListBox.DataSource = new BindingSource(productManager.CategoryDictionary[key], null);
                    itemsListBox.DisplayMember = "Name";
                    itemsListBox.Visible = true;
                }
            };*/
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form != this)
                    {
                        //Funkar ej när man försöker stänga i AdminMenu
                        form.Close();
                    }
                }
            }
        }


        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Denna ska vara tempcarten
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            usernameLabel.Visible = true;
            passwordLabel.Visible = true;
            usernameTextBox.Visible = true;
            passwordTextBox.Visible = true;
            logInButton.Visible = true;
            logOutButton.Visible = false;
            logOutButton.Location = new Point(881, 14);
            logOutButton.Size = new Size(94, 29);
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedIndex >= 0)
            {

                //string selectedItem = itemsListBox.SelectedItem.ToString();
                //MessageBox.Show($"{itemsListBox.SelectedItem.GetType()}");
                if (itemsListBox.SelectedItem is Product)
                {
                    Product item = (Product)itemsListBox.SelectedItem;
                    productManager.AddToCart(currentCart, item, 1);
                    //currentCart.AddProduct(item);
                }
                UpdateTotalCostLabel();
            }
            //foreach (Product product in currentCart.ProductsInCart)
            //{
            //    MessageBox.Show($"{product} was in cart");
            //}
        }

        private void itemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void proceedToCheckoutButton_Click(object sender, EventArgs e)
        {
            payment.Show();
        }

        private void cartListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListBoxes();
        }

        private void UpdateListBoxes()
        {
            // Updates Listbox DataSource when changing tab
            cartListBox.DisplayMember = "Name";
            cartListBox.DataSource = new BindingSource(currentCart.ProductsInCart, null);
        }

        private void UpdateTotalCostLabel()
        {
            int totalCost = currentCart.CalculateCartTotal();
            totalCostLabel.Text = $"Total Cost: {totalCost} kr";
        }

        private void totalCostLabel_Click(object sender, EventArgs e)
        {

        }

        private void removeItemFromCartButton_Click(object sender, EventArgs e)
        {
            if (cartListBox.SelectedIndex >= 0)
            {
                if (cartListBox.SelectedItem is Product)
                {
                    Product itemToRemove = (Product)cartListBox.SelectedItem;

                    productManager.RemoveFromCart(currentCart, itemToRemove, 1);

                    UpdateTotalCostLabel();
                    RefreshCartListBox();
                }
            }
        }
        private void RefreshCartListBox()
        {
            cartListBox.DisplayMember = "Name";
            cartListBox.DataSource = new BindingSource(currentCart.ProductsInCart, null);
        }
    }
}