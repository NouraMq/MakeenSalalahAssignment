using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.OOP.Models
{
    internal class Employee
    {
        public static double TAX = 0.03;

        public int Id;
        public string Fname;
        public string Lname;
        public decimal Wage; //Rate per hour/day
        public double loggedHours; //
        public int AbsenceDAY;
        public string DOB;
        //default Constructor
        //Empty Paramterless Constractor 
        public Employee()
        {

        }
        
        public Employee(int id, string Fname)
        {
            this.Id = id;
            this.Fname = Fname;

        }
        public Employee(int id, string Fname
           , string Lname, decimal wage, double loggedHours)
        {
            this.Id = id;
            this.Fname = Fname;
            this.Lname = Lname;
            this.Wage = wage;
            this.loggedHours = loggedHours;
        }
        public Employee(int id, string Fname
            , string Lname, decimal wage, double loggedHours
            , int Absence, string Date)
        {
            this.Id = id;
            this.Fname = Fname;
            this.Lname = Lname;
            this.Wage = wage;
            this.loggedHours = loggedHours;
        }
        // void ==> doesn't return anything 
        //Datatyped funtion  ==> return from the same datatype 
        public void Greeting()
        {
            Console.WriteLine("hello to the Company nerd ");
        }
        public string Greeting1()
        {

            return $"welcome {this.Fname} to the Company \n " +
                $"your id is {this.Id} \n with rate per hour {1000}  ";
        }
        //public bool hasAbsence()
        //{

        //}
        public static void PrintLn(int it = 10, char c = '~')
        {
            Console.WriteLine();
            for (int i = 0; i < it; i++)
            {
                Console.Write(c);
            }
            Console.WriteLine();
        }

        public static void swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;

        }
        //sugar syntax 
        public bool IsEven(int x) => x % 2 == 0;

        public bool IsEven1(int x)
        {
            if (x % 2 == 0)
            {
                return true;
            }
            return false;
        }

    }
}
