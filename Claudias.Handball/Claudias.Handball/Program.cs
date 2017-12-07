using System;
using Claudias.Handball.Repository;
using Claudias.Handball.Models;
using System.Collections.Generic;
using System.Text;
using Claudias.Handball.Repository.Core;
using System.Data.SqlClient;

namespace Claudias.Handball
{
    class Program
    {
        private static void ShowArticles(RepositoryContext repositoryContext)
        {
            List<Article> articles = repositoryContext.ArticleRepository.ReadAll();

            Console.WriteLine("Articles:");
            foreach (Article article in articles)
            {
             Console.WriteLine("{0} {1} {2} {3}", article.ArticleId,article.Title, article.Author,article.Description);
            }

        }
        private static void ShowArticle(RepositoryContext repositoryContext)
        {
            SqlParameter parameter = new SqlParameter("@ArticleID", "86CA5305-18F6-4A15-65BC-AB12345DD124");
            List<Article> articles=repositoryContext.ArticleRepository.ReadById(parameter );
            foreach(Article article in articles)
            Console.WriteLine("{0} {1} {2} {3}", article.ArticleId, article.Title, article.Author, article.Description);
        }

        private static void InsertArticle(RepositoryContext repositoryContext)
        {
            SqlParameter[] parameters = { new SqlParameter("@ArticleID", "86CA5305-18F6-4A15-65BC-AB12345DD124"),
                                          new SqlParameter("@Title","VICTORIEEEEE"),
                                          new SqlParameter("@Author","ION Jake"),
                                          new SqlParameter("@Description","description description description ")};

            repositoryContext.ArticleRepository.Insert(parameters);
        }

        private static void UpdateArticle(RepositoryContext repositoryContext)
        {
            SqlParameter[] parameters = { new SqlParameter("@ArticleID", "86CA5305-18F6-4A15-65BC-AB12345DD124"),
                                          new SqlParameter("@Title","WINNNNNNNNNNNNNNNNNNNNNNN"),
                                          new SqlParameter("@Author","ION Jake"),
                                          new SqlParameter("@Description","description description description ")};
            repositoryContext.ArticleRepository.Update(parameters);
        }
        private static void DeleteArticle(RepositoryContext repositoryContext)
        {
            SqlParameter parameter = new SqlParameter("@ArticleID", "86CA5305-18F6-4A15-65BC-AB12345DD124");
            repositoryContext.ArticleRepository.Delete( parameter);
        }


        static void Main(string[] args)
        {
            using (RepositoryContext repositoryContext = new RepositoryContext())
            {
                ShowArticles(repositoryContext);
                InsertArticle(repositoryContext);
                ShowArticle(repositoryContext);
                UpdateArticle(repositoryContext);
                DeleteArticle(repositoryContext);
                


                Console.ReadKey();
            }
        }
    }
}

