using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
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

        public static void updateCustomer(string username, string pin, string tlfnr, string cprnr, string email, string cardnumber, string balance, string originalCPR)
        {
            string tempPath = @"Customers_temp.csv";
            bool updated = false;

            using (StreamReader reader = new StreamReader(path))
            using (StreamWriter writer = new StreamWriter(tempPath))
            {
                string line;
                while ((line = reader.ReadLine()!) != null)
                {
                    string[] subs = line.Split(',');
                    if (subs[3] == originalCPR)
                    {
                        updated = true;
                        line = $"{username},{pin},{tlfnr},{cprnr},{email},{cardnumber},{balance}";
                    }
                    writer.WriteLine(line);
                }
            }

            if (updated)
            {
                File.Delete(path); 
                File.Move(tempPath, path); 
                MessageBox.Show("The customer was updated successfully!", "Updating", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                File.Delete(tempPath); 
                MessageBox.Show("That customer doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void updateBal(string username, string pin, string tlfnr, string cprnr, string email, string cardnumber, int balance)
        {
            string tempPath = @"Customers_temp.csv";
            bool updated = false;

            using (StreamReader reader = new StreamReader(path))
            using (StreamWriter writer = new StreamWriter(tempPath))
            {
                string line;
                while ((line = reader.ReadLine()!) != null)
                {
                    string[] subs = line.Split(',');
                    if (subs[0] == username)
                    {
                        updated = true;
                        line = $"{username},{pin},{tlfnr},{cprnr},{email},{cardnumber},{balance}";
                    }
                    writer.WriteLine(line);
                }
            }
            if (updated)
            {
                File.Delete(path);
                File.Move(tempPath, path);
            }
            else
            {
                File.Delete(tempPath);
            }
        }

        public static Customer readCustomer(string CPRNumber)
        {
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    string[] subs = s.Split(",");

                    if (subs[3] == CPRNumber)
                    {
                        return new Customer(subs[0], subs[1], subs[2], subs[3], subs[4], subs[5], subs[6]);
                    }
                }
            }

            MessageBox.Show("That customer doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }


        public static Customer deleteCustomer(string originalCPR)
        {
            string tempPath = @"Customers_temp.csv";
            bool deleted = false;

            using (StreamReader reader = new StreamReader(path))
            using (StreamWriter writer = new StreamWriter(tempPath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Split(',')[3] != originalCPR)
                    {
                        writer.WriteLine(line);
                    }
                    else
                    {
                        deleted = true;
                    }
                }
            }

            if (deleted)
            {
                File.Delete(path);
                File.Move(tempPath, path);
                MessageBox.Show("The customer was deleted successfully!", "Deleting", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                File.Delete(tempPath);
                MessageBox.Show("That customer doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
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