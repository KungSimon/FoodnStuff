namespace FoodnStuff
{
    public partial class Form1 : Form
    {
        private UserManager userManager;
        public Form1()
        {
            InitializeComponent();
            userManager = new UserManager();
        }



        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterUser registerUser = new RegisterUser(userManager);
            registerUser.Show();
        }

        private void logInWorkerButton_Click(object sender, EventArgs e)
        {
            WorkerLogIn workerLogIn = new WorkerLogIn(userManager);
            workerLogIn.Show();
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
                    return;
                }
            }
            MessageBox.Show("Invalid username or password. Please try again");
        }
    }
}