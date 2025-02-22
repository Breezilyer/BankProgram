using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BankSystem.CustomerFileHandling
{
    public class Customer
    {
        static string path = @"Customers.csv";
        public string Username { get; set; }
        public string Password { get; set; }
        public string Tlfnr { get; set; }
        public string Cprnr { get; set; }
        public string Email { get; set; }
        public string Cardnumber { get; set; }
        public string Balance { get; set; }

        public Customer(string username, string password, string tlfnr, string cprnr, string email, string cardnumber, string balance)
        {
            Username = username;
            Password = password;
            Tlfnr = tlfnr;
            Cprnr = cprnr;
            Email = email;
            Cardnumber = cardnumber;
            Balance = balance;
        }

        static void CustomerCSV()
        {
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()!) != null)
                {
                    WriteLine(s);
                }
            }
        }

    }
}
