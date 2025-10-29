using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.OOP.Models.SystemOrderMedum
{
   

   
    public class Order
    {
        private List<Product> products;

 
        public Order()
        {
            products = new List<Product>();
        }

     
        public void AddProduct(Product p)
        {
            products.Add(p);
        }

        
        public double CalculateTotalOrder()
        {
            double total = 0;
            foreach (var product in products)
            {
                total += product.CalculateTotal();
            }
            return total;
        }

    }
}
