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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BankSystem
{
    public partial class CustomerPage : Form
    {
        private string username;
        private string pin;
        private string tflnr;
        private string cpr;
        private string email;
        private string cardNum;
        private int bal;
        public CustomerPage(string user, string Pin, string Tlf, string Cpr, string Email, string CardNum, string balance)
        {
            InitializeComponent();
            username = user;
            this.Text = $"{username}'s Bank information";
            WelcomeLabel.Text = $"Hello, {username}!";

            bal = int.Parse(balance);
            Balance.Text = $"{bal}$";

            pin = Pin;
            tflnr = Tlf;
            cpr = Cpr;
            email = Email;
            cardNum = CardNum;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            int withdrawBoxInt = int.Parse(WithdrawBox.Text);
            bal -= withdrawBoxInt;
            Customer.updateBal(username, pin, tflnr, cpr, email, cardNum, bal);
            Balance.Text = $"{bal}$";
            WithdrawBox.Text = "";
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            int depositBoxInt = int.Parse(DepositBox.Text);
            bal += depositBoxInt;
            Customer.updateBal(username, pin, tflnr, cpr, email, cardNum, bal);
            Balance.Text = $"{bal}$";
            DepositBox.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            var loginPage = new LoginPage();
            this.Close();
            loginPage.Show();
        }
    }
}
