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
    public class MovieDAL
    {
        public static bool AddMovie(Movie movie)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = "INSERT INTO Movie (Title, Duration, Rating, Genre) VALUES ( @Title, @Duration, @Rating, @Genre)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Title", movie.Title);
                cmd.Parameters.AddWithValue("@Duration", movie.Duration);
                cmd.Parameters.AddWithValue("@Rating", movie.Rating);
                cmd.Parameters.AddWithValue("@Genre", movie.Genre);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static bool UpdateMovie(Movie movie)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = "UPDATE Movie SET Title = @Title, Duration = @Duration, Rating = @Rating, Genre = @Genre WHERE MovieID = @MovieID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MovieID", movie.MovieID);
                cmd.Parameters.AddWithValue("@Title", movie.Title);
                cmd.Parameters.AddWithValue("@Duration", movie.Duration);
                cmd.Parameters.AddWithValue("@Rating", movie.Rating);
                cmd.Parameters.AddWithValue("@Genre", movie.Genre);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static bool SoftDeleteMovie(int movieId)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = "UPDATE Movie SET IsDeleted = 1 WHERE MovieID = @MovieID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MovieID", movieId);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static List<Movie> GetAllMovies()
        {
            List<Movie> movies = new List<Movie>();

            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = "SELECT * FROM Movie WHERE IsDeleted = 0";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    movies.Add(new Movie
                    {
                        MovieID = Convert.ToInt32(reader["MovieID"]),
                        Title = reader["Title"].ToString(),
                        Duration = Convert.ToInt32(reader["Duration"]),
                        Rating = reader["Rating"].ToString(),
                        Genre = reader["Genre"].ToString()
                    });
                }
            }

            return movies;
        }
        public static DataTable GetDeletedMovies()
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = "SELECT * FROM Movie WHERE IsDeleted = 1";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
        public static bool RestoreMovie(int movieId)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = "UPDATE Movie SET IsDeleted = 0 WHERE MovieID = @MovieID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MovieID", movieId);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

    }
}

