using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CinemaTicketApp.DAL
{
    public static class DbHelper
    {
        public static string ConnectionString = @"Server=.\SQLEXPRESS;Database=CinemaTicketDB;Trusted_Connection=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
