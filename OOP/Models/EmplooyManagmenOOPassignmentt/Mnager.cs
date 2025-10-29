using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.OOP.Models.EmplooyManagment
{
    internal class Mnager
    {
        public class Manager : Employee
        {
            // كونستركتر يرث من الأب Employee باستخدام base
            public Manager(string name, decimal salary) : base(name, salary)
            {
            }

            // إعادة تعريف الدالة لحساب المكافأة
            public override decimal CalculateBonus()
            {
                return Salary * 0.20M; // 20%
            }
        }

    }
}
