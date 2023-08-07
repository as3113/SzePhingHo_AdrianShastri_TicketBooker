using System.Linq;
using System.Threading.Tasks;


namespace TicketREST.Models
{
    public class Response
    {
        public int StatusCode { get; set; }
        public string StatusMessage { get; set; }
        public Ticket Ticket { get; set; }
        public List<Ticket> TicketList { get; set; }
    }
    
}
