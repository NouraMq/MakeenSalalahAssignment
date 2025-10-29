using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.MakeenSenario
{
    internal class Inventrysystem
    {


        internal class StudentGradeSystem
        {
            public static void Run()
            { 

             
                
                    //            Assignment 3: Inventory Management System
                    // Concepts Used: Arrays, switch, conditions, loops
                    // Description:
                    //Simulate a mini inventory system where users can:
                    //-View available products.
                    //-Add quantity to a product.
                    //-Sell a product(decrease quantity).
                    //-Check stock of a product.
                    //Guidelines:
                    //            -Use 2 arrays:
                    //            -products[] — e.g., "Apple", "Orange", "Milk"
                    //            - quantities[] — corresponding stock numbers
                    //            - Show a menu using switch:
                    //1 → View All Products
                    //2 → Add Stock
                    //3 → Sell Product
                    //4 → Check Product Quantity
                    //5 → Exit
                    //- Ask for the product name when adding / selling / checking.
                    //- Use loops and conditions to find the product in the array and update quantity.
                    string[] products = { "Apple", "Orange", "Milk" };
                    int[] quantities = { 50, 30, 20 };
                    bool exit = false;
                    while (!exit)
                    {
                        Console.WriteLine("Inventory Management System");
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("1 → View All Products");
                        Console.WriteLine("2 → Add Stock");
                        Console.WriteLine("3 → Sell Product");
                        Console.WriteLine("4 → Check Product Quantity");
                        Console.WriteLine("5 → Exit");
                        Console.Write("Select an option: ");
                        string choice = Console.ReadLine();
                        switch (choice)
                        {
                            case "1":
                                Console.WriteLine("Available Products:");
                                for (int i = 0; i < products.Length; i++)
                                {
                                    Console.WriteLine($"{products[i]} - Quantity: {quantities[i]}");
                                }
                                break;
                            case "2":
                                Console.Write("Enter product name to add stock: ");
                                string addProduct = Console.ReadLine();
                                Console.Write("Enter quantity to add: ");
                                int addQty = int.Parse(Console.ReadLine());
                                for (int i = 0; i < products.Length; i++)
                                {
                                    if (products[i].Equals(addProduct, StringComparison.OrdinalIgnoreCase))
                                    {
                                        quantities[i] += addQty;
                                        Console.WriteLine($"Added {addQty} to {products[i]}. New quantity: {quantities[i]}");
                                        break;
                                    }
                                }
                                break;
                            case "3":
                                Console.Write("Enter product name to sell: ");
                                string sellProduct = Console.ReadLine();
                                Console.Write("Enter quantity to sell: ");
                                int sellQty = int.Parse(Console.ReadLine());
                                for (int i = 0; i < products.Length; i++)
                                {
                                    if (products[i].Equals(sellProduct, StringComparison.OrdinalIgnoreCase))
                                    {
                                        if (quantities[i] >= sellQty)
                                        {
                                            quantities[i] -= sellQty;
                                            Console.WriteLine($"Sold {sellQty} of {products[i]}. New quantity: {quantities[i]}");
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Insufficient stock for {products[i]}.");
                                        }
                                        break;
                                    }
                                }
                                break;
                            case "4":
                                Console.Write("Enter product name to check quantity: ");
                                string checkProduct = Console.ReadLine();
                                for (int i = 0; i < products.Length; i++)
                                {
                                    if (products[i].Equals(checkProduct, StringComparison.OrdinalIgnoreCase))
                                    {
                                        Console.WriteLine($"{products[i]} - Quantity: {quantities[i]}");
                                        break;
                                    }
                                }
                                break;
                            case "5":
                                exit = true;
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