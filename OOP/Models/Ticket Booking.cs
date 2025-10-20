using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment.OOP.Models
{
    internal class TicketBooking
    {
        public int SeatNumber { get; set; }
        public string EventName { get; set; }
        public string TicketType { get; set; }
      
        public TicketBooking(int SeatNumber, string EventName, string TicketType)
        {
            this.SeatNumber = SeatNumber;
            this.EventName = EventName;
            this.TicketType = TicketType;
            
    }
}
