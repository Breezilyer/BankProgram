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
        static string path = @"Customers.csv";
        public UpdateCustomerPage()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            string input = CPRNumber.Text;
            foreach (string line in File.ReadLines(path))
            {
                Customer customer = Customer.FromFileFormat(line);
                if (customer != null && customer.Cprnr == input)
                {
                    MessageBox.Show($"You have picked: {customer.Username}");
                }
            }
        }

        private void UsernameButton_Click(object sender, EventArgs e)
        {
            string input = CPRNumber.Text;

            Customer customer = customer.updateCustomer(Username.Text);
        }
    }
}
