using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.MakeenSenario
{
    internal class LibraryBook
    {
        
        
            public static void Run()
            {
                //            Assignment 7: Library Book Borrowing System
                //Concepts Used: Arrays, conditions, availability logic
                //Description:
                //            Build a basic library system to manage books.
                //Guidelines:
                //            -Arrays: books[], isBorrowed[]
                //-Menu:
                //1 → View Books
                //2 → Borrow Book
                //3 → Return Book
                //4 → Check Availability
                //5 → Exit
                //- Don’t allow borrowing an already borrowed book.
                //- Update status on borrow /return.

                string[] books = {
            "The Great Gatsby", "1984", "To Kill a Mockingbird",
            "Pride and Prejudice", "Moby Dick", "War and Peace",
            "The Catcher in the Rye", "Jane Eyre", "The Hobbit", "Crime and Punishment"
        };

                bool[] isBorrowed = new bool[books.Length];
                bool exit = false;

                while (!exit)
                {
                    Console.WriteLine("Library Book Borrowing System");
                    Console.WriteLine("1 → View Books");
                    Console.WriteLine("2 → Borrow Book");
                    Console.WriteLine("3 → Return Book");
                    Console.WriteLine("4 → Check Availability");
                    Console.WriteLine("5 → Exit");
                    Console.Write("Select an option: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1": // View Books
                            Console.WriteLine("Books in Library:");
                            for (int i = 0; i < books.Length; i++)
                            {
                                string status = isBorrowed[i] ? "Borrowed" : "Available";
                                Console.WriteLine($"{i + 1}. {books[i]} [{status}]");
                            }
                            break;

                        case "2": // Borrow Book
                            Console.Write("Enter book number to borrow: ");
                            if (int.TryParse(Console.ReadLine(), out int borrowIndex) &&
                                borrowIndex >= 1 && borrowIndex <= books.Length)
                            {
                                if (isBorrowed[borrowIndex - 1])
                                {
                                    Console.WriteLine("Sorry, this book is already borrowed.");
                                }
                                else
                                {
                                    isBorrowed[borrowIndex - 1] = true;
                                    Console.WriteLine($"You have borrowed \"{books[borrowIndex - 1]}\".");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid book number.");
                            }
                            break;

                        case "3": // Return Book
                            Console.Write("Enter book number to return: ");
                            if (int.TryParse(Console.ReadLine(), out int returnIndex) &&
                                returnIndex >= 1 && returnIndex <= books.Length)
                            {
                                if (!isBorrowed[returnIndex - 1])
                                {
                                    Console.WriteLine("This book was not borrowed.");
                                }
                                else
                                {
                                    isBorrowed[returnIndex - 1] = false;
                                    Console.WriteLine($"You have returned \"{books[returnIndex - 1]}\".");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid book number.");
                            }
                            break;

                        case "4": // Check Availability
                            Console.Write("Enter book number to check availability: ");
                            if (int.TryParse(Console.ReadLine(), out int checkIndex) &&
                                checkIndex >= 1 && checkIndex <= books.Length)
                            {
                                string status = isBorrowed[checkIndex - 1] ? "Borrowed" : "Available";
                                Console.WriteLine($"\"{books[checkIndex - 1]}\" is currently {status}.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid book number.");
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