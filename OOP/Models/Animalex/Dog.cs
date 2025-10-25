using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment.OOP.Models.Animalex
{
    
        class Dog : Animal
        {
            // Constructor to initialize the dog's name

            public Dog(string name) : base(name) { }

            // Implement MakeSound() method
            public override void MakeSound()
            {

                Console.WriteLine($"{Name} says: Woo!");
            }
        }
    }

