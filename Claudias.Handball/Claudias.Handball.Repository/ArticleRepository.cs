using Claudias.Handball.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Claudias.Handball.Repository
{
    public class ArticleRepository
    {

        #region Methods
        public List<Article> ReadAll()
        {
            List<Article> articles = new List<Article>();
            string connectionString = "Server=ADMIN-PC\\SQLEXPRESS;Database=Handball;Trusted_Connection=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "dbo.Articles_ReadAll";
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Article article = new Article();
                                article.ArticleId = reader.GetGuid(reader.GetOrdinal("ArticleID"));
                                article.Title = reader.GetString(reader.GetOrdinal("Title"));
                                article.Author = reader.GetString(reader.GetOrdinal("Author"));
                                article.Description = reader.GetString(reader.GetOrdinal("Description"));

                                articles.Add(article);
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

            return articles;
        }
        public Article ReadById(Guid articleId)
        {
            string connectionString = "Server=ADMIN-PC\\SQLEXPRESS;Database=Handball;Trusted_Connection=True;";
            Article article1 = new Article();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "dbo.Articles_ReadById";
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@ArticleID", articleId));
                        connection.Open();
                        command.ExecuteNonQuery();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                                reader.Read();
                                article1.ArticleId = reader.GetGuid(reader.GetOrdinal("ArticleID"));
                                article1.Title = reader.GetString(reader.GetOrdinal("Title"));
                                article1.Author = reader.GetString(reader.GetOrdinal("Author"));
                                article1.Description = reader.GetString(reader.GetOrdinal("Description"));
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
                return article1;
            }


        }
        public void Insert(Article article)
        {
            string connectionString = "Server=ADMIN-PC\\SQLEXPRESS;Database=Handball;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {

                    using (SqlCommand command = new SqlCommand())
                    {

                        command.Connection = connection;
                        command.CommandText = "dbo.Articles_Create";
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@ArticleID", article.ArticleId));
                        command.Parameters.Add(new SqlParameter("@Title", article.Title));
                        command.Parameters.Add(new SqlParameter("@Author", article.Author));
                        command.Parameters.Add(new SqlParameter("@Description", article.Description));
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
        public void Update(Article article)
        {
            string connectionString = "Server=ADMIN-PC\\SQLEXPRESS;Database=Handball;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "dbo.Articles_Update";
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@ArticleID", article.ArticleId));
                        command.Parameters.Add(new SqlParameter("@Title", article.Title));
                        command.Parameters.Add(new SqlParameter("@Author", article.Author));
                        command.Parameters.Add(new SqlParameter("@Description", article.Description));
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
        public void Delete(Article article)
        {
            string connectionString = "Server=ADMIN-PC\\SQLEXPRESS;Database=Handball;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "dbo.Articles_Delete";
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@ArticleID", article.ArticleId));
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
