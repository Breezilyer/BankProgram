using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BankSystem.File_Handling_Folder
{
    internal class FileHandling
    {
        static string path = @"Customers.csv";

        public static void CustomerCreate(Customer c)
        {
            if (!File.Exists(path))
            {
                StreamWriter sw = File.CreateText(path);
                sw.Close();
            }

            StreamWriter CustomerCreate = File.AppendText(path);
            CustomerCreate.WriteLine(c.Username + "," + c.Pin + "," + c.Tlfnr + "," + c.Cprnr + "," + c.Email + "," + c.Cardnumber + "," + c.Balance);
            CustomerCreate.Close();
        }
    }
}
