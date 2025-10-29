using Assignment2.AssignmentDay5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AssignmentDay5
{
    internal class Vehicle
    {
        
        // Create a base class Vehicle with:
        //- Make
        //- Model
        //- Year
      
        protected string make;
        protected string model;
        protected int year;
        //- Method DisplayInfo() to print vehicle details
        public Vehicle(string make, string model, int year)
        {
            this.make = make;
            this.model = model;
            this.year = year;
        }
        // Method to display vehicle information
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Make: {make}");
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Year: {year}");
        }
    }
}
//Create two derived classes:
//-Car(with extra field: number of doors)

class Car : Vehicle
{
    // Extra field: number of doors
    private int NumberOfDoors;
    // Constructor to initialize all fields
    public Car(string make, string model, int year, int numberOfDoors)
        : base(make, model, year)
    {
        this.NumberOfDoors = numberOfDoors;
    }
    // Override DisplayInfo() to include number of doors
    public override void DisplayInfo()
    {
        // Call base class method
        base.DisplayInfo();
        // Print number of doors
        Console.WriteLine($"Number of Doors: {NumberOfDoors}");
    }


};

// Truck(with extra field: load capacity)
class Truck : Vehicle
{
    // Extra field: load capacity
    private double LoadCapacity;
    // Constructor to initialize all fields
    public Truck(string make, string model, int year, double loadCapacity)
        : base(make, model, year)
    {// Initialize load capacity
        this.LoadCapacity = loadCapacity;
    }
    // Override DisplayInfo() to include load capacity
    public override void DisplayInfo()
    {
        // Call base class method
        base.DisplayInfo();
        // Print load capacity
        Console.WriteLine($"Load Capacity: {LoadCapacity} tons");
    }
}

