using Claudias.Handball.Models;
using System;
using System.Data.SqlClient;

namespace Claudias.Handball.Repository
{
    public class PlayerPhotoRepository
    {

        #region Methods
        public void Insert(PlayerPhoto playerPhoto)
        {
            string connectionString = "Server=ADMIN-PC\\SQLEXPRESS;Database=Handball;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "dbo.PlayersPhotos_Create";
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.Add(new SqlParameter("@PlayerID", playerPhoto.PlayerId));
                        command.Parameters.Add(new SqlParameter("@PhotoID", playerPhoto.PhotoId));
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

        public void Delete(PlayerPhoto playerPhoto)
        {
            string connectionString = "Server=ADMIN-PC\\SQLEXPRESS;Database=Handball;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "dbo.PlayersPhotos_Delete";
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@PlayerID", playerPhoto.PlayerId));
                        command.Parameters.Add(new SqlParameter("@PhotoID", playerPhoto.PhotoId));
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
