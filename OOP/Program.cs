using Assignment.OOP.Models;
using Assignment.OOP.Models.Animalex;
using Assignment.OOP.Models.SystemOrderMedum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.OOP
{

    class Program
}


//    COOOOOOODING ABOUT EMPLOOYEE MANAGMENT
//        static void Main()
//        {
            
//            List<Employee> employees = new List<Employee>
//        {
//            new Manager("Ahmed", 10000),
//            new Developer("Sara", 8000),
//            new Employee("Rahma", 6000)
//        };

          
//            HR hr = new HR();
//            hr.PrintBonuses(employees);
//        }
//    }
//}

//BANK ACCOUNT FILE CODE


//        BankAccount account1 = new BankAccount("564783", "NOURA", 1000);
//        BankAccount account2 = new BankAccount("984738", "ZAINA", 500);


//        account1.Deposit(200);
//        account2.Withdraw(100);


//        account2.Withdraw(8000);//عشان تظهر رساله خطأ دخلت مبلغ اكبر


//        Console.WriteLine($"5000 {account1.Owner}: {account1.Balance}1.000");
//        Console.WriteLine($"5000 {account2.Owner}: {account2.Balance} 1.000");


//        BankAccount.ShowTotalAccounts();
//    }
//}


//animal file CODE

//    static void MakeAllSounds(List<Animal> animals)
//    {
//        foreach (var animal in animals)
//        {
//            animal.MakeSound();
//        }
//    }

//    static void Main()
//    {

//        List<Animal> animals = new List<Animal>()
//    {
//        new Dog("Buddy"),
//        new Cat("Whiskers"),
//        new Cow("Bessie")
//    };


//        MakeAllSounds(animals);
//    }
//}


//SYSTEM ORDER FILE CODE


//        static void Main()
//        {
//            // إنشاء منتجات باستخدام البنّائين المحملين
//            Product prod1 = new Product(); // القيم الافتراضية
//            Product prod2 = new Product("Laptop", 1500.5, 2);

//            // حساب السعر باستخدام الدالة المحملة
//            double customTotal = prod2.CalculateTotal(1400.0, 3);

//            // إنشاء طلب وإضافة المنتجات
//            Order order = new Order();
//            order.AddProduct(prod1);
//            order.AddProduct(prod2);

//            // عرض النتائج
//            Console.WriteLine($"Total for prod1: {prod1.CalculateTotal()}");
//            Console.WriteLine($"Total for prod2: {prod2.CalculateTotal()}");
//            Console.WriteLine($"Custom total for prod2 with params: {customTotal}");
//            Console.WriteLine($"Total order cost: {order.CalculateTotalOrder()}");
//        }
//    }
//}
