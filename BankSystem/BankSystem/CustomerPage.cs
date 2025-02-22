﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BankSystem
{
    public partial class CustomerPage : Form
    {
        private string username;
        public CustomerPage(string user)
        {
            InitializeComponent();
            username = user;
            this.Text = $"Hello, {username}!";
        }
    }
}
