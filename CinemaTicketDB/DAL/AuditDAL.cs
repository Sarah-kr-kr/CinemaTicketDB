using CinemaTicketApp.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaTicketApp.Helpers;

namespace CinemaTicketApp.DAL
{
    public static class AuditDAL
    {
        /// <summary>
        /// تسجل عملية في جدول AuditTrail
        /// </summary>
        public static void LogAction(int userId, string actionType, string details)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = @"INSERT INTO AuditTrail (UserID, ActionType, ActionDetails) 
                                 VALUES (@UserID, @ActionType, @ActionDetails)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", userId);
                cmd.Parameters.AddWithValue("@ActionType", actionType);
                cmd.Parameters.AddWithValue("@ActionDetails", details);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// جلب جميع السجلات من جدول AuditTrail مع بيانات المستخدم
        /// </summary>
        public static DataTable GetAuditLogs()
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = @"
                    SELECT 
                        a.AuditID,
                        a.ActionTime,
                        u.FullName AS PerformedBy,
                        a.ActionType,
                        a.ActionDetails
                    FROM AuditTrail a
                    INNER JOIN Users u ON a.UserID = u.UserID
                    ORDER BY a.ActionTime DESC";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
    }
}
