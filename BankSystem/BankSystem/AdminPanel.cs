﻿using BankSystem.File_Handling_Folder;
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
            var loginPage = new LoginPage();
            this.Close();
            loginPage.Show();
        }

        private void UpdateCustomerButton_Click(object sender, EventArgs e)
        {
            var updateCustomerPage = new UpdateCustomerPage();
            this.Close();
            updateCustomerPage.Show();
        }

        private void ReadCustomerButton_Click(object sender, EventArgs e)
        {
            var readCustomer = new ReadCustomer();
            this.Close();
            readCustomer.Show();
        }

        private void DeleteCustomerButton_Click(object sender, EventArgs e)
        {
            var deleteCustomer = new DeleteCustomer();
            this.Close();
            deleteCustomer.Show();
        }
    }
}
