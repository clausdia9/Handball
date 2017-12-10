using Claudias.Handball.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Claudias.Handball.Repository.Core
{
    public abstract class BaseRepository<TModel>
    {
        #region Members
        protected static string _connectionString = GetConnectionString();
        #endregion

        #region Methods
        private static string GetConnectionString()
        {
           
            ConnectionStringSettings connectionStringSettings =ConfigurationManager.ConnectionStrings["Handball"];
              if (connectionStringSettings == null)
            {
              throw new ArgumentNullException("No connection string defined in the configuration file!");
            }
            return connectionStringSettings.ConnectionString;
            
        }

        public List<TModel> ReadAll(string storedProcedureName, SqlParameter[] parameters = default(SqlParameter[]))
        {
            List<TModel> result = new List<TModel>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        
                        command.Connection = connection;
                        command.CommandText = storedProcedureName;
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        if (parameters != null)
                           command.Parameters.AddRange(parameters);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                result.Add(GetModelFromReader(reader));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("There was an error: {0}", ex.ToString());
                }
            }

            return result;
        }

        public void Modify(string storedProcedureName, SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {

                    using (SqlCommand command = new SqlCommand())
                    {

                        command.Connection = connection;
                        command.CommandText =storedProcedureName;
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        if (parameters == null)
                        {
                            throw new Exception("SqlParameters must not be null!");
                        }
                        command.Parameters.AddRange(parameters);

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
        protected abstract TModel GetModelFromReader(SqlDataReader reader);
        #endregion
    }
}
