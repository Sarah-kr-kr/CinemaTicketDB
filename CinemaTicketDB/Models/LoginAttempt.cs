using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketApp.Models
{
    public class LoginAttempt
    {
        public int AttemptID { get; set; }
        public string Email { get; set; }
        public DateTime AttemptTime { get; set; }
        public bool IsSuccessful { get; set; }
    }
}

