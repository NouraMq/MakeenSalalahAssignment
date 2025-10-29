using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.OOP.Models.Animalex
{
   internal class Cow : Animal
    {

        
        // Constructor to initialize the cow's name
        public Cow(string name) : base(name) { }
        // Implement MakeSound() method
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: Moo!");
        }
    } }
