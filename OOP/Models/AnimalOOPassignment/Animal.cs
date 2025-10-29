using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.OOP.Models.Animalex
{
    public abstract class Animal
    {
        // Property to store the name of the animal
        public string Name { get; set; }

        // Constructor to initialize the animal's name
        public Animal(string name)
        {
            Name = name;
        }

        // Abstract method MakeSound() to be implemented by derived classes
        public abstract void MakeSound();
    }

}

