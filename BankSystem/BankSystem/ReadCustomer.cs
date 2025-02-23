using BankSystem.File_Handling_Folder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class ReadCustomer : Form
    {
        public ReadCustomer()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            Customer customer = Customer.readCustomer(CPRNumber.Text);
            if (customer != null)
            {
                MessageBox.Show($"Username: {customer.Username}\nPIN Code: {customer.Pin}\nPhone Number: {customer.Tlfnr}\nCPR Number: {customer.Cprnr}\nEmail: {customer.Email}\nCard Number: {customer.Cardnumber}\nBalance: {customer.Balance}$");
                var adminPanel = new AdminPanel();
                this.Close();
                adminPanel.Show();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            var adminPanel = new AdminPanel();
            this.Close();
            adminPanel.Show();
        }
    }
}
