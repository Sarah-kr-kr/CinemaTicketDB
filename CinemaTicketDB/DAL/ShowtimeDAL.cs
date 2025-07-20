using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CinemaTicketApp.Models;
using System.Data;

namespace CinemaTicketApp.DAL
{
    public class ShowtimeDAL
    {
        public static bool AddShowtime(Showtime showtime)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = "INSERT INTO Showtime (StartTime, Date, MovieID, HallID) VALUES ( @StartTime, @Date, @MovieID, @HallID)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StartTime", showtime.StartTime);
                cmd.Parameters.AddWithValue("@Date", showtime.Date);
                cmd.Parameters.AddWithValue("@MovieID", showtime.MovieID);
                cmd.Parameters.AddWithValue("@HallID", showtime.HallID);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static bool UpdateShowtime(Showtime showtime)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = "UPDATE Showtime SET StartTime = @StartTime, Date = @Date, MovieID = @MovieID, HallID = @HallID WHERE ShowtimeID = @ShowtimeID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ShowtimeID", showtime.ShowtimeID);
                cmd.Parameters.AddWithValue("@StartTime", showtime.StartTime);
                cmd.Parameters.AddWithValue("@Date", showtime.Date);
                cmd.Parameters.AddWithValue("@MovieID", showtime.MovieID);
                cmd.Parameters.AddWithValue("@HallID", showtime.HallID);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static bool SoftDeleteShowtime(int showtimeId)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = "UPDATE Showtime SET IsDeleted = 1 WHERE ShowtimeID = @ShowtimeID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ShowtimeID", showtimeId);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static List<Showtime> GetAllShowtimes()
        {
            List<Showtime> showtimes = new List<Showtime>();

            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = "SELECT * FROM Showtime WHERE IsDeleted = 0";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    showtimes.Add(new Showtime
                    {
                        ShowtimeID = Convert.ToInt32(reader["ShowtimeID"]),
                        StartTime = TimeSpan.Parse(reader["StartTime"].ToString()),
                        Date = Convert.ToDateTime(reader["Date"]),
                        MovieID = Convert.ToInt32(reader["MovieID"]),
                        HallID = Convert.ToInt32(reader["HallID"])
                    });
                }
            }

            return showtimes;
        }

        public static DataTable GetAllShowtimesWithDetails()
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = @"
            SELECT 
                s.ShowtimeID,
                s.Date,
                s.StartTime,
                m.MovieID,
                m.Title AS MovieTitle,
                h.HallID,
                h.HallName
            FROM Showtime s
            INNER JOIN Movie m ON s.MovieID = m.MovieID
            INNER JOIN Hall h ON s.HallID = h.HallID
        ";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }


    }
}

