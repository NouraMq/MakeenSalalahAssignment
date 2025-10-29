using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.MakeenSenario
{
    internal class ListApplication
    {
        
            public static void Run()
            {
                //            Assignment 6: To - Do List Application
                //Concepts Used: Arrays, loops, switch, boolean logic
                //Description:
                //            Create a task manager to handle personal tasks.
                //Guidelines:
                //            -Use two arrays: tasks[], isCompleted[]
                //-Menu:
                //1 → Add Task
                //2 → Delete Task
                //3 → Mark Task as Completed
                //4 → View Tasks
                //5 → Clear Completed Tasks
                //6 → Exit
                //- When deleting, shift array elements left.
                //-Display task status as Pending or Done.

                string[] tasks = new string[10];

                bool[] isCompleted = new bool[10];
                int taskCount = 0;
                bool exit = false;
                Console.WriteLine("To-Do List Application");
                while (!exit)
                {
                    Console.WriteLine("1 → Add Task");
                    Console.WriteLine("2 → Delete Task");
                    Console.WriteLine("3 → Mark Task as Completed");
                    Console.WriteLine("4 → View Tasks");
                    Console.WriteLine("5 → Clear Completed Tasks");
                    Console.WriteLine("6 → Exit");
                    Console.Write("Select an option: ");
                    string choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                            if (taskCount >= tasks.Length)
                            {
                                Console.WriteLine("Task list is full.");
                                break;
                            }
                            Console.Write("Enter task description: ");
                            string newTask = Console.ReadLine();
                            tasks[taskCount] = newTask;
                            isCompleted[taskCount] = false;
                            taskCount++;
                            Console.WriteLine("Task added.");
                            break;
                        case "2":
                            Console.Write("Enter task number to delete: ");
                            if (int.TryParse(Console.ReadLine(), out int deleteIndex) && deleteIndex > 0 && deleteIndex <= taskCount)
                            {
                                for (int i = deleteIndex - 1; i < taskCount - 1; i++)
                                {
                                    tasks[i] = tasks[i + 1];
                                    isCompleted[i] = isCompleted[i + 1];
                                }
                                tasks[taskCount - 1] = null;
                                isCompleted[taskCount - 1] = false;
                                taskCount--;
                                Console.WriteLine("Task deleted.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid task number.");
                            }
                            break;
                        case "3":
                            Console.Write("Enter task number to mark as completed: ");
                            if (int.TryParse(Console.ReadLine(), out int completeIndex) && completeIndex > 0 && completeIndex <= taskCount)
                            {
                                isCompleted[completeIndex - 1] = true;
                                Console.WriteLine("Task marked as completed.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid task number.");
                            }
                            break;
                        case "4":
                            Console.WriteLine("Tasks:");
                            for (int i = 0; i < taskCount; i++)
                            {
                                string status = isCompleted[i] ? "Done" : "Pending";
                                Console.WriteLine($"{i + 1}. {tasks[i]} - {status}");
                            }
                            break;
                        case "5":
                            int newCount = 0;
                            for (int i = 0; i < taskCount; i++)
                            {
                                if (!isCompleted[i])
                                {
                                    tasks[newCount] = tasks[i];
                                    isCompleted[newCount] = false;
                                    newCount++;
                                }
                            }
                            for (int i = newCount; i < taskCount; i++)
                            {
                                tasks[i] = null;
                                isCompleted[i] = false;



                            }
                            taskCount = newCount;
                            Console.WriteLine("Completed tasks cleared.");
                            break;
                        case "6":
                            exit = true;
                            Console.WriteLine("Exiting the application. Goodbye!");
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                }
            }
        }
    }