using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.MakeenSenario
{
    internal class Parking
    {
          public static void Run()
            {
                //            Assignment 5: Parking Lot System
                //Concepts Used: Arrays, loops, switch, conditions
                //Description:
                //Simulate a parking lot system with a limited number of slots.
                //Guidelines:
                //-Use an array slots[] of size 10 to store car license numbers.
                //- Menu:
                //1 → Park a Car
                //2 → Remove a Car
                //3 → View All Slots
                //4 → Search for a Car
                //5 → Exit
                //- Prevent duplicate entries.
                //- Validate empty or full slots.
                //- Use loops to add / remove / search slots.

                string[] slots = new string[10];
                bool exit = false;

                while (!exit)
                {
                    Console.WriteLine("Parking Lot System");
                    Console.WriteLine("1 → Park a Car");
                    Console.WriteLine("2 → Remove a Car");
                    Console.WriteLine("3 → View All Slots");
                    Console.WriteLine("4 → Search for a Car");
                    Console.WriteLine("5 → Exit");
                    Console.Write("Select an option: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1": // Park a Car
                            Console.Write("Enter car license number to park: ");
                            string license = Console.ReadLine();

                            // Check for duplicate
                            bool duplicate = false;
                            foreach (string car in slots)
                            {
                                if (car == license)
                                {
                                    duplicate = true;
                                    break;
                                }
                            }

                            if (duplicate)
                            {
                                Console.WriteLine("This car is already parked.");
                                break;
                            }
                            // Find empty slot
                            bool parked = false;
                            for (int i = 0; i < slots.Length; i++)
                            {
                                if (string.IsNullOrEmpty(slots[i]))
                                {
                                    slots[i] = license;
                                    Console.WriteLine($"Car parked in slot {i + 1}.");
                                    parked = true;
                                    break;
                                }
                            }

                            if (!parked)
                            {
                                Console.WriteLine("Parking lot is full.");
                            }
                            break;

                        case "2": // Remove a Car
                            Console.Write("Enter car license number to remove: ");
                            string removeLicense = Console.ReadLine();
                            bool found = false;

                            for (int i = 0; i < slots.Length; i++)
                            {
                                if (slots[i] == removeLicense)
                                {
                                    slots[i] = null;
                                    Console.WriteLine($"Car with license {removeLicense} removed from slot {i + 1}.");
                                    found = true;
                                    break;
                                }
                            }

                            if (!found)
                            {
                                Console.WriteLine("Car not found in the parking lot.");
                            }
                            break;

                        case "3": // View All Slots
                            Console.WriteLine("Parking Slots:");
                            for (int i = 0; i < slots.Length; i++)
                            {
                                string status = string.IsNullOrEmpty(slots[i]) ? "Empty" : slots[i];
                                Console.WriteLine($"Slot {i + 1}: {status}");
                            }
                            break;

                        case "4": // Search for a Car
                            Console.Write("Enter car license number to search: ");
                            string searchLicense = Console.ReadLine();
                            bool located = false;

                            for (int i = 0; i < slots.Length; i++)
                            {
                                if (slots[i] == searchLicense)
                                {
                                    Console.WriteLine($"Car found in slot {i + 1}.");
                                    located = true;
                                    break;
                                }
                            }

                            if (!located)
                            {
                                Console.WriteLine("Car not found in the parking lot.");
                            }
                            break;
                        case "5": // Exit
                            exit = true;
                            Console.WriteLine("Exiting the system. Goodbye!");
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


