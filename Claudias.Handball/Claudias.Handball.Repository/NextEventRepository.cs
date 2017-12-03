using Claudias.Handball.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Claudias.Handball.Repository
{
    public class NextEventRepository
    {

        #region Methods
        public List<NextEvent> ReadAll()
        {
            List<NextEvent> nextEvents = new List<NextEvent>();
            string connectionString = "Server=ADMIN-PC\\SQLEXPRESS;Database=Handball;Trusted_Connection=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "dbo.NextEvents_ReadAll";
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                NextEvent nextEvent = new NextEvent();
                                nextEvent.EventId = reader.GetGuid(reader.GetOrdinal("EventID"));
                                nextEvent.EventName = reader.GetString(reader.GetOrdinal("EventName"));
                                nextEvent.Location = reader.GetString(reader.GetOrdinal("Location"));
                                nextEvent.Date = reader.GetDateTime(reader.GetOrdinal("Date"));

                                nextEvents.Add(nextEvent);
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

            return nextEvents;
        }
        public NextEvent ReadById(Guid eventId)
        {
            string connectionString = "Server=ADMIN-PC\\SQLEXPRESS;Database=Handball;Trusted_Connection=True;";
            NextEvent nextEvent1 = new NextEvent();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "dbo.NextEvents_ReadById";
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@EventID", eventId));
                        connection.Open();
                        command.ExecuteNonQuery();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            reader.Read();
                            nextEvent1.EventId = reader.GetGuid(reader.GetOrdinal("EventID"));
                            nextEvent1.EventName = reader.GetString(reader.GetOrdinal("EventName"));
                            nextEvent1.Location = reader.GetString(reader.GetOrdinal("Location"));
                            nextEvent1.Date = reader.GetDateTime(reader.GetOrdinal("Date"));
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
                return nextEvent1;
            }


        }
        public void Insert(NextEvent nextEvent)
        {
            string connectionString = "Server=ADMIN-PC\\SQLEXPRESS;Database=Handball;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {

                    using (SqlCommand command = new SqlCommand())
                    {

                        command.Connection = connection;
                        command.CommandText = "dbo.NextEvents_Create";
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@EventID", nextEvent.EventId));
                        command.Parameters.Add(new SqlParameter("@EventName", nextEvent.EventName));
                        command.Parameters.Add(new SqlParameter("@Location", nextEvent.Location));
                        command.Parameters.Add(new SqlParameter("@Date", nextEvent.Date));
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
        public void Update(NextEvent nextEvent)
        {
            string connectionString = "Server=ADMIN-PC\\SQLEXPRESS;Database=Handball;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "dbo.NextEvents_Update";
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@EventID", nextEvent.EventId));
                        command.Parameters.Add(new SqlParameter("@EventName", nextEvent.EventName));
                        command.Parameters.Add(new SqlParameter("@Location", nextEvent.Location));
                        command.Parameters.Add(new SqlParameter("@Date", nextEvent.Date));
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
        public void Delete(NextEvent nextEvent)
        {
            string connectionString = "Server=ADMIN-PC\\SQLEXPRESS;Database=Handball;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "dbo.NextEvents_Delete";
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@EventID", nextEvent.EventId));
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
