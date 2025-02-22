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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void CreateCustomerButton_Click(object sender, EventArgs e)
        {
            var createCustomerPage = new AddCustomerPage();
            this.Close();
            createCustomerPage.Show();

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            var loginPage = new LoginPage();
            loginPage.Show();
        }
    }
}
