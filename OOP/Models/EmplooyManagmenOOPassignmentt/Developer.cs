using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.OOP.Models.EmplooyManagment
{
    
        public class Developer : Employee
        {
            public Developer(string name, decimal salary) : base(name, salary)
            {
            }

            public override decimal CalculateBonus()
            {
                return Salary * 0.15M; // 15%
            }
        }

    }
}
