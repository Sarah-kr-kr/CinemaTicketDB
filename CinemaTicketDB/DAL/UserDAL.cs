using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CinemaTicketApp.Models;

namespace CinemaTicketApp.DAL
{
    public class UserDAL
    {
        public static bool AddUser(User user)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = @"INSERT INTO Users (FullName, Email, Password, PhoneNumber, Role)
                                 VALUES (@FullName, @Email, @Password, @PhoneNumber, @Role)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FullName", user.FullName);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Role", user.Role);

                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        public static User Authenticate(string email, string hashedPassword)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = "SELECT * FROM Users WHERE Email = @Email AND Password = @Password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", hashedPassword);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new User
                    {
                        UserID = Convert.ToInt32(reader["UserID"]),
                        FullName = reader["FullName"].ToString(),
                        Email = reader["Email"].ToString(),
                        Role = reader["Role"].ToString(),
                        PhoneNumber = reader["PhoneNumber"]?.ToString()
                    };
                }
                return null;
            }
        }

        public static bool EmailExists(string email)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Users WHERE Email = @Email";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
    }
}

