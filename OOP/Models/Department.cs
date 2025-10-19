using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.OOP.Models
{
    internal class Department
    {
        private int id;
        private string name;
        private string description;
        public Department()
        {

        }

        public Department(string name, string description)
        {
            this.name = name;
            this.description = description;
        }
        //public void SetName(string Name)
        //{
        //    this.name = Name;
        //}
        public string GetName()
        {
            return this.name;
        }
        public Department(int id, string name, string description)
        {
            this.id = id;
            this.name = name;
            this.description = description;
        }
    }
}
