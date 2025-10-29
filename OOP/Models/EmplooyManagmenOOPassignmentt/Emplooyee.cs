using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.OOP.Models.EmplooyManagment
{
      public class Employee
    {
        public string Name { get; set; }
        private decimal salary; // نخفي الراتب هنا ونضبط وصوله من الخارج بمراجعة القيمة

        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                    salary = 0;
                else
                    salary = value;
            }
        }

        // الكونستركتر يستقبل الاسم والراتب 
        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }

        // دالة افتراضية لحساب المكافأة
        public virtual decimal CalculateBonus()
        {
            return Salary * 0.10M; // 10% من الراتب
        }
    }

    
    }

