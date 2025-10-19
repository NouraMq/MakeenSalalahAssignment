using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.OOP.Models
{
    internal class Person
    {
        //private int id;
        //private string name;
        //private string age;
        //        bool IsMarried;
        public int id { get; set; }
        public string name { get; set; }
        public string age { get; set; }
        public bool IsMarried { get; set; }

        public Person(int id, string name, string age, bool isMarried)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.IsMarried = isMarried;
        }
        //public int GetId()
        //{
        //    return this.id;
        //}
        //public string GetName()
        //{
        //    return this.name;
        //}
        //public void setName(string name)
        //{
        //    this.name = name;
    }
}
