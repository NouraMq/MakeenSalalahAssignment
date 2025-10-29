using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.OOP.Models.EmplooyManagment
{
  
public class HR
    {
        public void PrintBonuses(List<Employee> employees)
        {
            foreach (var emp in employees)
            {
                Console.WriteLine($" Ahme {emp.Name}, 500 {emp.CalculateBonus()} 1.000");
            }
        }
    }

}

