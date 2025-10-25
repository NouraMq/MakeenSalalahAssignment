using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment.OOP.Models.Animalex
{
    
        class Cat : Animal
    {
        // Constructor to initialize the cat's name
        public Cat(string name) : base(name) { }
        // Implement MakeSound() method
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: Meow!");
        }
    } }
    
