using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AssignmentDay5
{
    internal class Student
    {
        //public int Id { get; set; }
        //public string Name { get; set; }
        //private int grade {  get; set; }

        //public Student(string name, int id)
        //{
        //    Name = name;
        //    Id = id;
        //    grade = new List<int>();

        // Properties of the Student class 
        private string name;
        private int id;
        private List<int> grades;

        // Constructor to initialize the Student object
        public Student(string name, int id, List<int> grades)
        {
            // Initialize properties
            this.name = name;
            this.id = id;
            this.grades = grades;
        }
        // Method to add a grade to the student's grade list
        public int AddGrade(int grade)
        {
            // Add the grade to the list
            grades.Add(grade);
            // Return the added grade
            return grade;
        }
        // Method to calculate the average grade of the student
        public double CalculateAverageGrade()
        {
            // Check if there are no grades to avoid division by zero
            if (grades.Count == 0)
            {
                return 0;
            }
            // Calculate and return the average grade
            return grades.Average();
        }
        // Method to print the student's report
        public void PrintStudentReport()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine("---------------------------");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Grades: {string.Join(", ", grades)}");


        }
    }
}
