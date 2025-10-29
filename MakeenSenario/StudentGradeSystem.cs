using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.MakeenSenario
{
    internal class StudentGradeSystem
    {
     public StudentGradeSystem() { }
            public static void Run()
            {


                //            Assignment 4: Student Grade Management System
                //Concepts Used: Arrays, loops, conditions, math logic
                //Description:
                //            Create an app to manage students and their grades.
                //            Guidelines:
                //-Use arrays: students[], grades[]
                //-Menu:
                //1 → Add Student
                //2 → Update Grade
                //3 → View All Students and Grades
                //4 → Show Average, Highest, and Lowest Grades
                //5 → Exit
                //- Validate that grade is between 0 and 100.
                //- Use loops to search, update, and calculate stats.

                //----------------------------------

                string[] students = new string[10];
                int[] grades = new int[10];
                int studentCount = 0;

                // بيانات مبدئية
                string[] initialStudents = { "Alice", "Bob", "Charlie", "Diana", "Ethan", "Fiona", "George", "Hannah", "Ian", "Julia" };
                int[] initialGrades = { 85, 92, 78, 90, 88, 76, 95, 89, 84, 91 };

                for (int i = 0; i < initialStudents.Length; i++)
                {
                    students[i] = initialStudents[i];
                    grades[i] = initialGrades[i];
                }
                studentCount = initialStudents.Length;

                bool exit = false;
                while (!exit)
                {
                    Console.WriteLine("Student Grade Management System");
                    Console.WriteLine("1 → Add Student");
                    Console.WriteLine("2 → Update Grade");
                    Console.WriteLine("3 → View All Students and Grades");
                    Console.WriteLine("4 → Show Average, Highest, and Lowest Grades");
                    Console.WriteLine("5 → Exit");
                    Console.Write("Select an option: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            if (studentCount < students.Length)
                            {
                                Console.Write("Enter student name: ");
                                string name = Console.ReadLine();
                                Console.Write("Enter student grade (0-100): ");
                                int grade;
                                while (!int.TryParse(Console.ReadLine(), out grade) || grade < 0 || grade > 100)
                                {
                                    Console.Write("Invalid grade. Please enter a grade between 0 and 100: ");
                                }
                                students[studentCount] = name;
                                grades[studentCount] = grade;
                                studentCount++;
                                Console.WriteLine("Student added successfully.");
                            }
                            else
                            {
                                Console.WriteLine("Student list is full.");
                            }
                            break;

                        case "2":
                            Console.Write("Enter student name to update grade: ");
                            string searchName = Console.ReadLine();
                            int index = Array.IndexOf(students, searchName, 0, studentCount);
                            if (index != -1)
                            {
                                Console.Write("Enter new grade (0-100): ");
                                int newGrade;
                                while (!int.TryParse(Console.ReadLine(), out newGrade) || newGrade < 0 || newGrade > 100)
                                {
                                    Console.Write("Invalid grade. Please enter a grade between 0 and 100: ");
                                }
                                grades[index] = newGrade;
                                Console.WriteLine("Grade updated successfully.");
                            }
                            else
                            {
                                Console.WriteLine("Student not found.");
                            }
                            break;

                        case "3":
                            Console.WriteLine("Students and Grades:");
                            for (int i = 0; i < studentCount; i++)
                            {
                                Console.WriteLine($"{students[i]} - Grade: {grades[i]}");
                            }
                            break;

                        case "4":
                            Console.WriteLine("Grade Statistics:");
                            if (studentCount > 0)
                            {
                                double average = 0;
                                int highest = grades[0];
                                int lowest = grades[0];
                                for (int i = 0; i < studentCount; i++)
                                {
                                    average += grades[i];
                                    if (grades[i] > highest) highest = grades[i];
                                    if (grades[i] < lowest) lowest = grades[i];
                                }
                                average /= studentCount;
                                Console.WriteLine($"Average Grade: {average:F2}");
                                Console.WriteLine($"Highest Grade: {highest}");
                                Console.WriteLine($"Lowest Grade: {lowest}");
                            }
                            else
                            {
                                Console.WriteLine("No students available to calculate statistics.");
                            }
                            break;

                        case "5":
                            exit = true;
                            Console.WriteLine("Exiting the program. Goodbye!");
                            break;

                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }

                    Console.WriteLine();

                }
            }
        }
    }
}
}
