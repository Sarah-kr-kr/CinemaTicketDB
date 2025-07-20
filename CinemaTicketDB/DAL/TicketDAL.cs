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
    public class TicketDAL
    {
        public static bool AddTicket(Ticket ticket)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = "INSERT INTO Ticket (SeatNumber, ShowtimeID, UserID) VALUES (@SeatNumber, @ShowtimeID, @UserID)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SeatNumber", ticket.SeatNumber);
                cmd.Parameters.AddWithValue("@ShowtimeID", ticket.ShowtimeID);
                cmd.Parameters.AddWithValue("@UserID", ticket.UserID);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static bool IsSeatAlreadyBooked(int showtimeId, string seatNumber)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = @"SELECT COUNT(*) 
                         FROM Ticket 
                         WHERE ShowtimeID = @ShowtimeID 
                         AND SeatNumber = @SeatNumber
                         AND (IsDeleted = 0 OR IsDeleted IS NULL)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ShowtimeID", showtimeId);
                cmd.Parameters.AddWithValue("@SeatNumber", seatNumber);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }


        public static bool SoftDeleteTicket(int ticketId)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = "UPDATE Ticket SET IsDeleted = 1 WHERE TicketID = @TicketID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TicketID", ticketId);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        /*public static List<Ticket> GetTicketsByUser(int userId)
        {
            List<Ticket> tickets = new List<Ticket>();

            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = "SELECT * FROM Ticket WHERE UserID = @UserID AND IsDeleted = 0 ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", userId);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tickets.Add(new Ticket
                    {
                        TicketID = Convert.ToInt32(reader["TicketID"]),
                        SeatNumber = reader["SeatNumber"].ToString(),
                        ShowtimeID = Convert.ToInt32(reader["ShowtimeID"]),
                        UserID = Convert.ToInt32(reader["UserID"])
                    });
                }
            }

            return tickets;
        }*/

        public static List<Ticket> GetAllTickets()
        {
            List<Ticket> tickets = new List<Ticket>();

            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = "SELECT * FROM Ticket";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tickets.Add(new Ticket
                    {
                        TicketID = Convert.ToInt32(reader["TicketID"]),
                        SeatNumber = reader["SeatNumber"].ToString(),
                        ShowtimeID = Convert.ToInt32(reader["ShowtimeID"]),
                        UserID = Convert.ToInt32(reader["UserID"])
                    });
                }
            }

            return tickets;
        }

        public static bool BookTicketWithTransaction(Ticket ticket)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 1. إضافة التذكرة
                    string insertQuery = @"INSERT INTO Ticket (UserID, ShowtimeID, SeatNumber)
                                   VALUES (@UserID, @ShowtimeID, @SeatNumber)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn, transaction);
                    insertCmd.Parameters.AddWithValue("@UserID", ticket.UserID);
                    insertCmd.Parameters.AddWithValue("@ShowtimeID", ticket.ShowtimeID);
                    insertCmd.Parameters.AddWithValue("@SeatNumber", ticket.SeatNumber);
                    insertCmd.ExecuteNonQuery();

                    // 3. نجاح: تثبيت التغييرات
                    transaction.Commit();
                    return true;
                }
                catch
                {
                    // فشل: تراجع عن التغييرات
                    transaction.Rollback();
                    return false;
                }
            }
        }

        public static DataTable GetTicketsByUser(int userId)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = @"
            SELECT t.TicketID, m.Title, h.HallName, t.SeatNumber, s.Date, s.StartTime
            FROM Ticket t
            INNER JOIN Showtime s ON t.ShowtimeID = s.ShowtimeID
            INNER JOIN Movie m ON s.MovieID = m.MovieID
            INNER JOIN Hall h ON s.HallID = h.HallID
            WHERE t.UserID = @UserID AND t.IsDeleted = 0";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", userId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }


    }
}

