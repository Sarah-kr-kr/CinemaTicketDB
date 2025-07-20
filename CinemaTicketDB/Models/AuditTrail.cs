using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketDB.Models
{
    public class AuditTrail
    {
        public int AuditID { get; set; }
        public DateTime ActionTime { get; set; }
        public int UserID { get; set; }
        public string ActionType { get; set; }
        public string ActionDetails { get; set; }
    }
}
