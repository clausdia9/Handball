using Claudias.Handball.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Claudias.Handball.Repository
{
    public class PlayerRepository
    {

        #region Methods
        public List<Player> ReadAll()
        {
            List<Player> players = new List<Player>();
            string connectionString = "Server=ADMIN-PC\\SQLEXPRESS;Database=Handball;Trusted_Connection=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "dbo.Players_ReadAll";
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Player player = new Player();
                                player.PlayerId = reader.GetGuid(reader.GetOrdinal("PlayerID"));
                                player.PlayerName = reader.GetString(reader.GetOrdinal("PlayerName"));
                                player.Goals = reader.GetInt32(reader.GetOrdinal("Goals"));
                                player.BirthDay = reader.GetDateTime(reader.GetOrdinal("BirthDay"));
                                players.Add(player);
                            }
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    Console.WriteLine("There was an SQL error: {0}", sqlEx.ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("There was an error: {0}", ex.ToString());
                }

            }

            return players;
        }
        public Player ReadById(Guid playerId)
        {
            string connectionString = "Server=ADMIN-PC\\SQLEXPRESS;Database=Handball;Trusted_Connection=True;";
            Player player1 = new Player();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "dbo.Players_ReadById";
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@PlayerID", playerId));
                        connection.Open();
                        command.ExecuteNonQuery();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            reader.Read();
                            player1.PlayerId= reader.GetGuid(reader.GetOrdinal("PlayerID"));
                            player1.PlayerName= reader.GetString(reader.GetOrdinal("PlayerName"));
                            player1.Goals = reader.GetInt32(reader.GetOrdinal("Goals"));
                            player1.BirthDay = reader.GetDateTime(reader.GetOrdinal("BirthDay"));
                        }
                    }

                }
                catch (SqlException sqlEx)
                {
                    Console.WriteLine("There was an SQL error: {0}", sqlEx.ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("There was an error: {0}", ex.ToString());
                }
                return player1;
            }


        }
        public void Insert(Player player)
        {
            string connectionString = "Server=ADMIN-PC\\SQLEXPRESS;Database=Handball;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {

                    using (SqlCommand command = new SqlCommand())
                    {

                        command.Connection = connection;
                        command.CommandText = "dbo.Players_Create";
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@PlayerID", player.PlayerId));
                        command.Parameters.Add(new SqlParameter("@PlayerName", player.PlayerName));
                        command.Parameters.Add(new SqlParameter("@Goals", player.Goals));
                        command.Parameters.Add(new SqlParameter("@BirthDay", player.BirthDay));
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                catch (SqlException sqlEx)
                {
                    Console.WriteLine("There was an SQL error: {0}", sqlEx.ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("There was an error: {0}", ex.ToString());
                }
            }
        }
        public void Update(Player player)
        {
            string connectionString = "Server=ADMIN-PC\\SQLEXPRESS;Database=Handball;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "dbo.Players_Update";
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@PlayerID", player.PlayerId));
                        command.Parameters.Add(new SqlParameter("@PlayerName", player.PlayerName));
                        command.Parameters.Add(new SqlParameter("@Goals", player.Goals));
                        command.Parameters.Add(new SqlParameter("@BirthDay", player.BirthDay));
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                catch (SqlException sqlEx)
                {
                    Console.WriteLine("There was an SQL error: {0}", sqlEx.ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("There was an error: {0}", ex.ToString());
                }
            }
        }
        public void Delete(Player player)
        {
            string connectionString = "Server=ADMIN-PC\\SQLEXPRESS;Database=Handball;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "dbo.Players_Delete";
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@PlayerID", player.PlayerId));
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                catch (SqlException sqlEx)
                {
                    Console.WriteLine("There was an SQL error: {0}", sqlEx.ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("There was an error: {0}", ex.ToString());
                }
            }
        }
        #endregion Methods
    }
}
