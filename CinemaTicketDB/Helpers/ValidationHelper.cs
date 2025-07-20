using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CinemaTicketApp.Helpers
{
    public static class ValidationHelper
    {
        public static bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        public static bool IsValidPassword(string password)
        {
            // ≥ 8 أحرف، تحتوي على حرف كبير وصغير ورقم ورمز خاص
            return Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$");
        }

        public static bool IsValidFullName(string name)
        {
            return Regex.IsMatch(name, @"^[A-Za-z\u0600-\u06FF ]{5,}$");
        }

        public static bool IsValidPhone(string phone)
        {
            return Regex.IsMatch(phone, @"^[0-9]{7,15}$");
        }
    }
}

