using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketApp.Helpers
{
    public static class SecurityHelper
    {
        /// <summary>
        /// دالة لتشفير أي نص (مثل كلمة المرور) باستخدام SHA256
        /// </summary>
        public static string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2")); // hex string
                }
                return builder.ToString();
            }
        }
    }
}
