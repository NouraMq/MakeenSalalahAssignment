using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.OOP.Models.User
{
    internal class NormalUser
    {
        public int Numberoforder { get; set; }
        public int lastOrderIsShipped { get; set; }
        public int Rating { get; set; }
        public virtual void welcomeMessage()
        {
            Console.WriteLine($"welcome user{this.Numberoforder}");
        }
    }
}

