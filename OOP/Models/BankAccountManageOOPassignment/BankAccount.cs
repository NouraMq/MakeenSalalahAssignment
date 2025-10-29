using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.OOP.Models.BankAccountManage
{
    internal class BankAccount

    {
        
        private static int totalAccounts = 0;

        
        private string accountNumber;
        private decimal balance;
        private string owner;

        
        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        
        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        
        public decimal Balance
        {
            get { return balance; }
            private set
            {
                if (value < 0)
                {
                    Console.WriteLine("CANT");
                }
                else
                {
                    balance = value;
                }
            }
        }

       
        public  BankAccount(string accNum, string accOwner, decimal initialBalance)
        {
            AccountNumber = accNum;
            Owner = accOwner;
            Balance = initialBalance;
            totalAccounts++; 
        }

        
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"DONE {amount} 1.000: {Balance} 1.000.");
            }
            else
            {
                Console.WriteLine("3.000.");
            }
        }

      
        public void Withdraw(decimal amount)
        {
            if (amount > 0)
            {
                if (amount <= Balance)
                {
                    Balance -= amount;
                    Console.WriteLine($"DONE {amount} 1.000: {Balance} 1.000.");
                }
                else
                {
                    Console.WriteLine("CANT");
                }
            }
            else
            {
                Console.WriteLine("400");
            }
        }

        
        public static void ShowTotalAccounts()
        {
            Console.WriteLine($"3: {totalAccounts}");
        }
    }
}
