using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment.OOP.Models
{
    internal class Book
    {
        public int IsbnNo { get; set; }
        public string Title { get; set; }
        public string Athour { get; set; }
        public string Year { get; set; }
        public Book(int IsbnNo, string Titlee, string Athour, string Year)
        {
            this.IsbnNo = IsbnNo;
            this.Title = Title;
            this.Athour = Athour;
            this.Year = Year;
        }
    }
}
