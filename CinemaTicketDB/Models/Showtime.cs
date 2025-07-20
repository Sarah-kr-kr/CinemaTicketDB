using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketApp.Models
{
    public class Showtime
    {
        public int ShowtimeID { get; set; }
        public TimeSpan StartTime { get; set; }
        public DateTime Date { get; set; }

        public int MovieID { get; set; }
        public int HallID { get; set; }
    }
}

