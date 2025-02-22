using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.File_Handling_Folder
{
    public class Customer
    {
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
    }
}
