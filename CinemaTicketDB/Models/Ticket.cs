using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketApp.Models
{
    public class Ticket
    {
        public int TicketID { get; set; }
        public string SeatNumber { get; set; }

        public int ShowtimeID { get; set; }
        public int UserID { get; set; }
    }
}

