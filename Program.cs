using Assignment.OOP.Models;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //String s1 = new String("yousif");
            //int x = 10;
            #region EmployeeFirst
            //Employee emp = new Employee();
            // emp.Id = 1;
            // emp.Fname = "Yousif";
            // emp.Lname = "Ebrahim";
            // emp.Wage = 3;
            // emp.loggedHours = 10;

            // Console.WriteLine(emp);

            // Employee emp1 = new Employee();
            // emp1.Id = 2;
            // emp1.Fname = "Ahmed";
            // emp1.Lname = "Al Shanfary";
            // emp1.Wage = 10;
            // emp1.loggedHours = 50; 
            #endregion

            //استنادا علي القواهد البرمجية ان يمكن  انشاء ارراي من اي داتا طايب
            #region Employee Department Tax Calc
            // Employee[] emp = new Employee[3];

            // for (int i = 0; i < emp.Length; i++)
            // {
            //     emp[i] = new Employee();
            //     Console.WriteLine($"Please enter emp {i} First Name :");
            //     emp[i].Fname = Console.ReadLine();

            //     Console.WriteLine($"Please enter emp {i} Last Name :");
            //     emp[i].Lname = Console.ReadLine();

            //     Console.WriteLine($"Please enter emp{i} Wage (Rate per hour) :");
            //     emp[i].Wage = Decimal.Parse(Console.ReadLine());

            //     Console.WriteLine($"Please enter emp{i} Logged Hours (Working Hours) :");
            //     emp[i].loggedHours = double.Parse(Console.ReadLine());


            // }

            // foreach (Employee item in emp)
            // {
            //     decimal NetSalary = (item.Wage * (decimal)item.loggedHours) - (item.Wage * (decimal)(item.loggedHours * Employee.TAX));
            //     Console.WriteLine($" Employee {item.Fname} : Net Salary is {NetSalary}");
            // }

            //Department Dep = new Department();
            // Dep.id = 1;
            // Dep.name = "Information Technology";
            // Dep.description = "bto3 rbna ";
            // int x;
            // const int y = 3;
            // Employee.TAX = 0.04; 
            #endregion
            #region Lecture 5

            //Employee e = new Employee();
            //e.Id = 1;
            //e.Fname = "Test";
            //e.AbsenceDAY = 1;
            //e.Wage = 10;
            //e.loggedHours = 10;
            //Employee e1 = new Employee();
            //e1.Id = 2;
            //e1.Fname = "yousif";
            //e1.AbsenceDAY = 100;
            //e1.Wage = 100000000000000;
            //e1.loggedHours = 10;
            ////string val =   e.Greeting1();
            ////Console.WriteLine(val);
            //Console.WriteLine(e.Greeting1());
            //Employee.PrintLn(30 , '&');
            //Console.WriteLine(e1.Greeting1());
            //Employee.PrintLn(50, '@');
            //Employee.PrintLn();

            //int a = 3, b = 5; 
            //Employee.swap(ref a, ref b);
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //Console.WriteLine(Calculator.Add(3, 4));
            //Console.WriteLine(Calculator.Add(3.2, 4.3));
            //Console.WriteLine(Calculator.Add("yousif", "Mohamed"));
            ////create Object or Instance
            //Calculator cal = new Calculator();



            /* 
             * 
               Create a Calculator Class that have 
            Multiply integers and Double and string
            in the string case he should take string 
            and int as a parameter
            and return the string appear the same as 
            the number 
            (string * 3 ) string string string  
             
             
             
             */
            //Console.WriteLine(Calculator.Multiply(3, 4));
            //Console.WriteLine(Calculator.Multiply(2.5, 1.5));
            //Console.WriteLine(Calculator.Multiply("chew", 4));

            #endregion



            Employee emp = new Employee
                (1, "Yousif", "Ebrahim", 10, 10);
            Employee emp1 = new Employee
                (2, "Fatima", "Alshanfry", 20, 10);
            //emp.Id = 1;
            Employee emp2 = new Employee(3, "Ahmed", "Ali");
            Employee emp3 = new Employee(4, "Adel");

            Console.WriteLine(emp.Fname);


            Department dep = new Department();
            //dep.id = 1;
            //dep.name = "Marketing";
            //dep.description = "Social Media Awarnes for company Services";

            //Department dep1 = new Department("it" , "Development and Ai ");
            ////dep1.name = "Information Technology";
            //Console.WriteLine(dep1.GetName());    
            //Employee emp4 = new Employee { 
            //    Fname = "yousif",
            //    Lname = "Ebrahim"

            //};

            //Person p1 = new Person(1,"yousif" , "22" , false);
            //Console.WriteLine(p1.GetId());
            //Console.WriteLine(p1.GetName());
            //p1.setName("morad");
            //Console.WriteLine(p1.GetName()); 

            BankAccount acc = new BankAccount(1, "yousif", "ebrahim", 2000, "79211717");

            Console.WriteLine(acc.WithDraw(-1000)); ;

        }








    } 
}

