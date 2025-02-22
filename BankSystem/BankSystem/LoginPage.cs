using BankSystem.File_Handling_Folder;
using System.Security.Cryptography.X509Certificates;

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
            string path = @"Customers.csv";
            string username = LoginUsername.Text;
            string password = LoginPIN.Text;

            // Admin Login
            var adminPanel = new AdminPanel();

            if (username == "admin" && password == "1234")
            {
                this.Hide();
                LoginUsername.Text = "";
                LoginPIN.Text = "";
                adminPanel.Show();
            }

            // Customer Login

            foreach (string line in File.ReadLines(path))
            {
                Customer customer = Customer.FromFileFormat(line);
                if (customer != null && customer.Username == username && customer.Pin == password)
                {
                    this.Hide();
                    var customerPage = new CustomerPage(customer.Username);
                    customerPage.Show();
                }
            }
        }
    }
}
