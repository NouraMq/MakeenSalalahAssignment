using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AssignmentDay5
{
    public class Book
    {

        public string Title { get; set; }
        public int ISBN { get; set; }
        public int Year { get; set; }
        public string Author { get; set; }
        public Book(string Title, int ISBN, int Year, string Author)
        {
            this.Title = Title;
            this.ISBN = ISBN;
            this.Year = Year;
            this.Author = Author;
        }



        public string PrintBookInfo()
        {
            return $" {this.Title} {this.ISBN} {this.Year} {this.Author}";  
        }

        public bool Check(int checkYear)
        {
            if (checkYear > Year)
            {
                return true;
            }
            return false;
        }








    }
}