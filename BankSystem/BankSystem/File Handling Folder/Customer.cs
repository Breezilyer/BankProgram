using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BankSystem.File_Handling_Folder
{
    public class Customer
    {
        static string path = @"Customers.csv";
        public string Username { get; set; }
        public string Pin { get; set; }
        public string Tlfnr { get; set; }
        public string Cprnr { get; set; }
        public string Email { get; set; }
        public string Cardnumber { get; set; }
        public string Balance { get; set; }

        public Customer(string username, string pin, string tlfnr, string cprnr, string email, string cardnumber, string balance)
        {
            Username = username;
            Pin = pin;
            Tlfnr = tlfnr;
            Cprnr = cprnr;
            Email = email;
            Cardnumber = cardnumber;
            Balance = balance;
        }

        public void Create()
        {
            File_Handling_Folder.FileHandling.CustomerCreate(this);
        }

        public void updateCustomer(string update)
        {
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Split(',')[3] == Cprnr)
                {
                    string line = lines[i];
                    Customer customer = Customer.FromFileFormat(line);
                    customer.Username = update;
                    customer.Pin = update;
                    customer.Tlfnr = update;
                    customer.Cprnr = update;
                    customer.Email = update;
                    customer.Cardnumber = update;
                    customer.Balance = update;
                    File.WriteAllLines(path, lines);
                }
            }
        }

        public static Customer FromFileFormat(string line)
        {
            string[] parts = line.Split(',');
            if (parts.Length == 7)
            {
                return new Customer(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5], parts[6]);
            }
            return null;
        }
    }
}
