using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CinemaTicketApp.Models;

namespace CinemaTicketApp.DAL
{
    public class LoginAttemptDAL
    {
        public static void AddAttempt(LoginAttempt attempt)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = "INSERT INTO LoginAttempts (Email, AttemptTime, IsSuccessful) VALUES (@Email, @AttemptTime, @IsSuccessful)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", attempt.Email);
                cmd.Parameters.AddWithValue("@AttemptTime", attempt.AttemptTime);
                cmd.Parameters.AddWithValue("@IsSuccessful", attempt.IsSuccessful);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static int CountFailedAttempts(string email, DateTime fromTime)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM LoginAttempts WHERE Email = @Email AND IsSuccessful = 0 AND AttemptTime >= @FromTime";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@FromTime", fromTime);

                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        public static void ClearAttempts(string email)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = "DELETE FROM LoginAttempts WHERE Email = @Email";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}

