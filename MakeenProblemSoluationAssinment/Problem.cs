using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.MakeenProblemSoluation
{
    internal class Problem
    {
        static void Main(string[] args)
        {
            //problem 1 
            //for (int a = 1; a <= 10; a++) 
            //{ 
            // Console.Write((2 * a) + " "); 
            // } 

            // int b = 0; 
            // int c = 1; 


            //problem2 

            //int b = 0; 
            //int c = 1; 
            //Console.Write(b + " " + c + " "); 
            //for (int i = 2; i < 15; i++) 
            // { 
            //int next = b + c; 
            // Console.Write(next + " "); 
            // b = c; 
            //c = next; 
            //} 


            //problem3 
            //for (int power = 0; power < 10; power++) 
            //{ 
            //Console.Write(Math.Pow(2, power) + " "); 
            // } 

            //problem 5 
            //int size = 5; 
            //Console.WriteLine("Square pattern:"); 
            //for (int k = 0; k < size; k++) 
            //{ 
            //for (int j = 0; j < size; j++) 
            // { 
            // Console.Write("* "); 
            // } 
            //Console.WriteLine(); 
            //} 

            //problem6 
            // int numberInput = Convert.ToInt32(Console.ReadLine()); 
            // bool isPrime = true; 
            //if (numberInput <= 1) 
            //{ isPrime = false; } 
            //else 
            //{ 
            //for (int l = 2; l <= Math.Sqrt(numberInput); l++) 
            //{ 
            // if (numberInput % l == 0) 
            //{ 
            // isPrime = false; 
            // break; 
            //} 
            //} 
            // Console.WriteLine($"{numberInput} is {(isPrime ? "prime" : "not prime")}"); 

            //problem7 

            Console.Write("Enter an integer: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int temp = Math.Abs(number);
            while (temp > 0)
            {
                sum += temp % 10;
                temp /= 10;
            }
            Console.WriteLine("Sum of digits: " + sum);


            //problem8 

            Console.Write("Say Somthing: ");
            string input = Console.ReadLine();
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reversed = new string(charArray);
            Console.WriteLine($"Reversed string: {reversed}");

            //problem9 
            Console.Write("Say Something: ");
            string markMyWord = Console.ReadLine().ToLower();
            int vowelCount = 0;
            string vowels = "aeiou";
            foreach (char vow in markMyWord)
            {
                if (vowels.Contains(vow))
                {
                    vowelCount++;
                }
            }
            Console.WriteLine("Vowels in my Word: " + vowelCount);


            //problem10 

            int evenSum = 0;
            for (int p = 2; p <= 100; p += 2)
            {
                evenSum += p;
            }
            Console.WriteLine("Sum of even numbers from 1 to 100: " + evenSum);

            //problem11 

            Console.Write("Enter Number: ");
            int myNumber = Convert.ToInt32(Console.ReadLine());
            long factorial = 1;
            for (int i = 1; i <= myNumber; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"Factorial of {myNumber} is: {factorial}");


            //problem12 

            int[] numberArray = { 64, 34, 25, 12, 22, 11, 90 };
            Console.WriteLine("Original array:");


            // Bubble sort 
            for (int x = 0; x < numberArray.Length - 1; x++)
            {
                for (int z = 0; z < numberArray.Length - x - 1; z++)
                {
                    if (numberArray[z] > numberArray[z + 1])
                    {
                        // Swap 
                        int tempx = numberArray[z];
                        numberArray[z] = numberArray[z + 1];
                        numberArray[z + 1] = tempx;
                    }
                }
            }

            Console.WriteLine("Sorted array:");

            Console.WriteLine("Hello, World!");
        }
    }
}
