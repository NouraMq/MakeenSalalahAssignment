using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.MakeenSenario
{
    internal class MovieSeat
    {
          static char[,] seats = new char[5, 5];

            static void Main()
            {
                InitializeSeats();

                int choice;
                do
                {
                    Console.WriteLine("\n--- Movie Theatre Seat Booking System ---");
                    Console.WriteLine("1. View Seats");
                    Console.WriteLine("2. Book Seat");
                    Console.WriteLine("3. Cancel Booking");
                    Console.WriteLine("4. Show Available Seat Count");
                    Console.WriteLine("5. Exit");
                    Console.Write("Enter your choice: ");

                    bool validInput = int.TryParse(Console.ReadLine(), out choice);
                    if (!validInput)
                    {
                        Console.WriteLine("Invalid input. Please enter a number from 1 to 5.");
                        continue;
                    }

                    switch (choice)
                    {
                        case 1:
                            ViewSeats();
                            break;
                        case 2:
                            BookSeat();
                            break;
                        case 3:
                            CancelSeat();
                            break;
                        case 4:
                            ShowAvailableSeats();
                            break;
                        case 5:
                            Console.WriteLine("Thank you for using the booking system.");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please select from the menu.");
                            break;
                    }

                } while (choice != 5);
            }

            static void InitializeSeats()
            {
                for (int i = 0; i < 5; i++)
                    for (int j = 0; j < 5; j++)
                        seats[i, j] = 'A'; // A = Available
            }

            static void ViewSeats()
            {
                Console.WriteLine("\nSeat Layout (A = Available, X = Booked):");
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write(seats[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }

            static void BookSeat()
            {
                Console.Write("Enter row (0-4): ");
                int row = GetValidIndex();
                Console.Write("Enter column (0-4): ");
                int col = GetValidIndex();

                if (seats[row, col] == 'X')
                {
                    Console.WriteLine("Seat already booked. Please choose another seat.");
                }
                else
                {
                    seats[row, col] = 'X';
                    Console.WriteLine("Seat booked successfully.");
                }
            }

            static void CancelSeat()
            {
                Console.Write("Enter row (0-4): ");
                int row = GetValidIndex();
                Console.Write("Enter column (0-4): ");
                int col = GetValidIndex();

                if (seats[row, col] == 'A')
                {
                    Console.WriteLine("Seat is not booked yet.");
                }
                else
                {
                    seats[row, col] = 'A';
                    Console.WriteLine("Booking cancelled successfully.");
                }
            }

            static void ShowAvailableSeats()
            {
                int count = 0;
                for (int i = 0; i < 5; i++)
                    for (int j = 0; j < 5; j++)
                        if (seats[i, j] == 'A')
                            count++;

                Console.WriteLine($"Available seats: {count}");
            }

            static int GetValidIndex()
            {
                int index;
                while (true)
                {
                    bool valid = int.TryParse(Console.ReadLine(), out index);
                    if (valid && index >= 0 && index < 5)
                        return index;
                    Console.Write("Invalid input. Enter a number between 0 and 4: ");
                }
            }
        }


    }


