using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.OOP.Models
{
    internal class Calcolator
    {
        // 3 Add Methods 
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static double Add(double x, double y)
        {
            return x + y;
        }
        public static string Add(string x, string y)
        {
            return x + y;
        }

        //3 Multiply method
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        public static double Multiply(double x, double y)
        {
            return x * y;
        }
        public static string Multiply(string x, int y)
        {
            string result = "";
            for (int i = 0; i < y; i++)
            {
                result += $"{x} ";
            }
            return result;
        }
    }
}
