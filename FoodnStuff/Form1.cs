using System.Windows.Forms;

namespace FoodnStuff
{
    public partial class Form1 : Form
    {
        private ChooseTransport chooseTransport;
        private UserManager userManager = UserManager.GetInstance();
        private ProductManager productManager = ProductManager.GetInstance();
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            this.chooseTransport = new ChooseTransport();
        }



        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterUser registerUser = new RegisterUser(userManager);
            registerUser.Show();
        }

        private void logInWorkerButton_Click(object sender, EventArgs e)
        {
            WorkerLogIn workerLogIn = new WorkerLogIn(userManager, this, productManager, chooseTransport);

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
                    return;
                }
            }
            MessageBox.Show("Invalid username or password. Please try again");
        }

        private void catagoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            catagoryListBox.DataSource = new BindingSource(productManager.CategoryDictionary.Keys, null);
            itemsListBox.DataSource = new BindingSource(productManager.CategoryDictionary, null);
            catagoryListBox.SelectedIndexChanged += (sender, args) =>
            {
                if (catagoryListBox.SelectedIndex >= 0)
                {
                    string key = catagoryListBox.SelectedItem.ToString();
                    listBox2.DataSource = new BindingSource(productManager.CategoryDictionary[key], null);
                }
            };
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

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            //Här ska det sparas
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Här ska det försvinna
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Denna ska vara tempcarten
        }
    }
}