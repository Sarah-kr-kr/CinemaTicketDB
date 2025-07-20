using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketApp.Models
{
    public class ApiMessage
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public string username { get; set; }
        public string message { get; set; }
        public bool is_read { get; set; }
        public string system_id { get; set; }
        public string created_at { get; set; }
    }

    public class ApiData
    {
        public List<ApiMessage> messages { get; set; }
        public int total_count { get; set; }
        public Dictionary<string, object> filters { get; set; }
    }

    public class ApiResponse
    {
        public bool success { get; set; }
        public string message { get; set; }
        public ApiData data { get; set; }
    }
}