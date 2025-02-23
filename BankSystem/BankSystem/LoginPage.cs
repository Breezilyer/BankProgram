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

            if (!File.Exists(path))
            {
                StreamWriter sw = File.CreateText(path);
                sw.Close();
            }

            // Admin Login
            if (username == "admin" && password == "1234")
            {
                this.Hide();
                var adminPanel = new AdminPanel();
                adminPanel.Show();
            }

            // Customer Login
            foreach (string line in File.ReadLines(path))
            {
                Customer customer = Customer.FromFileFormat(line);
                if (customer != null && customer.Username == username && customer.Pin == password)
                {
                    this.Hide();
                    var customerPage = new CustomerPage(customer.Username, customer.Pin, customer.Tlfnr, customer.Cprnr, customer.Email, customer.Cardnumber, customer.Balance);
                    customerPage.Show();
                }
            }
        }
    }
}
