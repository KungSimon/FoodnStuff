namespace FoodnStuff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterUser registerUser = new RegisterUser();
            registerUser.Show();
        }

        private void logInWorkerButton_Click(object sender, EventArgs e)
        {
            WorkerLogIn workerLogIn = new WorkerLogIn();
            workerLogIn.Show();
        }
    }
}