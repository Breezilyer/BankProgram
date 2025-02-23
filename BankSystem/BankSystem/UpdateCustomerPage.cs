using BankSystem.File_Handling_Folder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BankSystem
{
    public partial class UpdateCustomerPage : Form
    {
        public UpdateCustomerPage()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            string path = @"Customers.csv";
            foreach (string line in File.ReadLines(path))
            {
                string input = CPRNumber.Text;
                Customer customer = Customer.FromFileFormat(line);
                if (customer != null && customer.Cprnr == input)
                {
                    this.Hide();
                    var customerPage = new CustomerPage(customer.Username);
                    customerPage.Show();
                }
            }
        }
    }
}
