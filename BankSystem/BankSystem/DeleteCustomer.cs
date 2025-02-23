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
    public partial class DeleteCustomer : Form
    {
        public DeleteCustomer()
        {
            InitializeComponent();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Customer customer = Customer.deleteCustomer(CPRNumber.Text);
            var adminPanel = new AdminPanel();
            this.Close();
            adminPanel.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            var adminPanel = new AdminPanel();
            this.Close();
            adminPanel.Show();
        }
    }
}
