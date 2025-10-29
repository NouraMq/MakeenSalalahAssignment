using Assignment.Exam.SalalahDelivary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.MakeenSenario
{

    internal class Program
    {
        static void Main(string[] args)
        {


            Customer customer1 = new Customer("Ali", "Alqurm");
            Customer customer2 = new Customer("Fatima", "Muscat City");

            Driver driver1 = new Driver("RAHMA", "9556478");
            Driver driver2 = new Driver("KHALID", "7653397");

            Delivery delivery1 = new Delivery(customer1, driver1);
            Delivery delivery2 = new Delivery(customer2, driver2);
            Delivery delivery3 = new Delivery(customer1, driver1);

            delivery1.UpdateStatus(ShipmentStatus.OnTheWay);
            delivery2.UpdateStatus(ShipmentStatus.Delivered);

            delivery1.PrintDetails();
            delivery2.PrintDetails();
            delivery3.PrintDetails();

            driver1.PrintDeliveries();
        }
    }
}