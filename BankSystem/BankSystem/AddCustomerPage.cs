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
    public partial class AddCustomerPage : Form
    {
        public AddCustomerPage()
        {
            InitializeComponent();
        }

        private void CreateCustomerButton_Click(object sender, EventArgs e)
        {
            string username = cUsername.Text;
            string pin = cPin.Text;
            string tlf = cPhoneNumber.Text;
            string cpr = cCPRNumber.Text;
            string email = cEmail.Text;
            string card = cCardNumber.Text;
            string bal = cBalance.Text;

            Customer c = new Customer(username, pin, tlf, cpr, email, card, bal);
            c.Create();

            cUsername.Text = "";
            cPin.Text = "";
            cPhoneNumber.Text = "";
            cCPRNumber.Text = "";
            cEmail.Text = "";
            cCardNumber.Text = "";
            cBalance.Text = "";

            MessageBox.Show("Customer Created! :3");
            this.Close();

            var adminPanel = new AdminPanel();
            adminPanel.Show();
        }
    }
}
