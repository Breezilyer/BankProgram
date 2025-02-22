namespace BankSystem
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

            string username = LoginUsername.Text;
            string password = LoginPIN.Text;

            // Admin Login
            var adminPanel = new AdminPanel();

            if (username == "admin" &&  password == "1234")
            {
                LoginUsername.Text = "";
                LoginPIN.Text = "";
                adminPanel.Show();
            }
            

            // Here will the Customer login be vv
        }
    }
}
