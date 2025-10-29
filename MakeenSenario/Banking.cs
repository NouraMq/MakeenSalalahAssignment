using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.MakeenSenario
{
    internal class Banking
    {
       
            static string[] usernames = { "user1", "user2" };
            static string[] passwords = { "pass1", "pass2" };
            static double[] balances = { 1000.0, 1500.0 };
            public static void Run()
            {


                Console.WriteLine("=== Welcome to Simple Bank System ===");

                int userIndex = Login();

                if (userIndex == -1)
                {
                    Console.WriteLine("Invalid credentials. Exiting...");
                    return;
                }

                int choice;
                do
                {
                    Console.WriteLine("\n--- Menu ---");
                    Console.WriteLine("1. Check Balance");
                    Console.WriteLine("2. Deposit Money");
                    Console.WriteLine("3. Withdraw Money");
                    Console.WriteLine("4. Transfer Money");
                    Console.WriteLine("5. Exit");
                    Console.Write("Enter your choice: ");
                    choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine($"Your balance: {balances[userIndex]} OMR");
                            break;

                        case 2:
                            Console.Write("Enter amount to deposit: ");
                            double deposit = double.Parse(Console.ReadLine());
                            balances[userIndex] += deposit;
                            Console.WriteLine("Deposit successful.");
                            break;

                        case 3:
                            Console.Write("Enter amount to withdraw: ");
                            double withdraw = double.Parse(Console.ReadLine());
                            if (withdraw <= balances[userIndex])
                            {
                                balances[userIndex] -= withdraw;
                                Console.WriteLine("Withdrawal successful.");
                            }
                            else
                            {
                                Console.WriteLine("Insufficient balance.");
                            }
                            break;

                        case 4:
                            Console.Write("Enter recipient username: ");
                            string recipient = Console.ReadLine();
                            int recipientIndex = Array.IndexOf(usernames, recipient);

                            if (recipientIndex == -1 || recipientIndex == userIndex)
                            {
                                Console.WriteLine("Invalid recipient.");
                                break;
                            }

                            Console.Write("Enter amount to transfer: ");
                            double transfer = double.Parse(Console.ReadLine());

                            if (transfer <= balances[userIndex])
                            {
                                balances[userIndex] -= transfer;
                                balances[recipientIndex] += transfer;
                                Console.WriteLine("Transfer successful.");
                            }
                            else
                            {
                                Console.WriteLine("Insufficient balance.");
                            }
                            break;

                        case 5:
                            Console.WriteLine("Thank you for using Simple Bank System.");
                            break;

                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }

                } while (choice != 5);
            }

            static int Login()
            {
                Console.Write("Enter username: ");
                string user = Console.ReadLine();
                Console.Write("Enter password: ");
                string pass = Console.ReadLine();

                for (int i = 0; i < usernames.Length; i++)
                {
                    if (usernames[i] == user && passwords[i] == pass)
                    {
                        Console.WriteLine("Login successful.");
                        return i;
                    }
                }

                return -1;


            }
        }
    }
}
