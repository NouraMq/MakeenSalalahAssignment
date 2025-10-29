using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.OOP.Models.SystemOrderMedum
{
    


public class Product
        {
            public string Name;
            public double Price;
            public int Quantity;

           
            public Product()
            {
                Name = "Undefined";
                Price = 0.0;
                Quantity = 0;
            }

            
            public Product(string name, double price, int quantity)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
            }

          
            public double CalculateTotal()
            {
                return Price * Quantity;
            }

         
            public double CalculateTotal(double price, int quantity)
            {
                return price * quantity;
            }
        }

    }

