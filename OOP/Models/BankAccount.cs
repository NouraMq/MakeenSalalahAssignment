using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.OOP.Models
{
    internal class BankAccount
    {
        public const decimal MAXWITHDRAW = 5000;

        public BankAccount(int id, string firstName, string lastName, decimal balance, string phoneNumber)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Balance = balance;
            PhoneNumber = phoneNumber;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Balance { get; set; }
        public string PhoneNumber { get; set; }

        public string WithDraw(decimal amount)
        {
            if (amount > MAXWITHDRAW)
            {
                return $"you Can't With Draw more than {MAXWITHDRAW} per day";
            }
            else if (amount < 0)
            {
                return $"invalid amoount please enter a positive amount  ";
            }
            if (this.Balance >= amount)
            {
                this.Balance -= amount;

                return $"withdraw successfully please take the money and your current balance is {this.Balance}";
            }
            return $"something went wrong ";

        }

    }
}
