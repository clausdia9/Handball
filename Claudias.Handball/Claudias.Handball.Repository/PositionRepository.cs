using Claudias.Handball.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Claudias.Handball.Repository
{
    public class PositionRepository
    {

        #region Methods
        public List<Position> ReadAll()
        {
            List<Position> positions = new List<Position>();
            string connectionString = "Server=ADMIN-PC\\SQLEXPRESS;Database=Handball;Trusted_Connection=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "dbo.Positions_ReadAll";
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                               Position position = new Position();
                                position.PositionId = reader.GetGuid(reader.GetOrdinal("PositionID"));
                                position.PositionName = reader.GetString(reader.GetOrdinal("PositionName"));
                                positions.Add(position);
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

            return positions;
        }
        public Position ReadById(Guid positionId)
        {
            string connectionString = "Server=ADMIN-PC\\SQLEXPRESS;Database=Handball;Trusted_Connection=True;";
            Position position1 = new Position();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "dbo.Positions_ReadById";
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@PositionID", positionId));
                        connection.Open();
                        command.ExecuteNonQuery();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            reader.Read();
                            position1.PositionId = reader.GetGuid(reader.GetOrdinal("PositionID"));
                            position1.PositionName = reader.GetString(reader.GetOrdinal("PositionName"));
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
                return position1;
            }


        }
        public void Insert(Position position)
        {
            string connectionString = "Server=ADMIN-PC\\SQLEXPRESS;Database=Handball;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {

                    using (SqlCommand command = new SqlCommand())
                    {

                        command.Connection = connection;
                        command.CommandText = "dbo.Positions_Create";
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@PositionID", position.PositionId));
                        command.Parameters.Add(new SqlParameter("@PositionName", position.PositionName));
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
        public void Update(Position position)
        {
            string connectionString = "Server=ADMIN-PC\\SQLEXPRESS;Database=Handball;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "dbo.Positions_Update";
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@PositionID", position.PositionId));
                        command.Parameters.Add(new SqlParameter("@PositionName", position.PositionName));
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
        public void Delete(Position position)
        {
            string connectionString = "Server=ADMIN-PC\\SQLEXPRESS;Database=Handball;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "dbo.Positions_Delete";
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@PositionID", position.PositionId));
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
