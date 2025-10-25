using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.OOP.Models.User
{
    public abstract class User
    {
        public int Id { get; set; }
        public string FulName { get; set; }
        public DateOnly DOB { get; set; }
        public string Pass { get; set; }
        public string Email { get; set; }

        public virtual void welcomeMessage()
        {
            Console.WriteLine($"welcome user{this.FulName}");
        }
    }
}
