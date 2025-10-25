using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.OOP.Models
{
    internal class Emplooyees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string TotalSales { get; set; }
        public Emplooyees(int id, string Name, string Gender, string TotalSales)
        {
            this.Id = id;
            this.Name = Name;
            this.Gender = Gender;
            this.TotalSales = TotalSales;


        }
    }
}
