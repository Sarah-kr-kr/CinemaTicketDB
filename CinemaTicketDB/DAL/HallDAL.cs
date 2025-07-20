using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CinemaTicketApp.Models;

namespace CinemaTicketApp.DAL
{
    public class HallDAL
    {
        public static bool AddHall(Hall hall)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = "INSERT INTO Hall (HallName, SeatsCapacity) VALUES ( @HallName, @SeatsCapacity)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@HallName", hall.HallName);
                cmd.Parameters.AddWithValue("@SeatsCapacity", hall.SeatsCapacity);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static bool UpdateHall(Hall hall)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = "UPDATE Hall SET HallName = @HallName, SeatsCapacity = @SeatsCapacity WHERE HallID = @HallID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@HallID", hall.HallID);
                cmd.Parameters.AddWithValue("@HallName", hall.HallName);
                cmd.Parameters.AddWithValue("@SeatsCapacity", hall.SeatsCapacity);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static bool SoftDeleteHall(int hallId)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = "UPDATE Hall SET IsDeleted = 1 WHERE WHERE HallID = @HallID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@HallID", hallId);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static List<Hall> GetAllHalls()
        {
            List<Hall> halls = new List<Hall>();

            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = "SELECT * FROM Hall WHERE IsDeleted = 0";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    halls.Add(new Hall
                    {
                        HallID = Convert.ToInt32(reader["HallID"]),
                        HallName = reader["HallName"].ToString(),
                        SeatsCapacity = Convert.ToInt32(reader["SeatsCapacity"])
                    });
                }
            }

            return halls;
        }
    }
}

