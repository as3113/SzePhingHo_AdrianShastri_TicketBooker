using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketTest.Models
{
    public class Ticket
    {
        public int ticketId { get; set; }
        /*public string train { get; set; } // add new attribute*/
        public string departure { get; set; }
        public string destination { get; set; }
        public DateTime departureTime { get; set; }
        public DateTime arrivalTime { get; set; }
        public string category { get; set; }
        public string seat { get; set; }
        public decimal price { get; set; }
    }
}
