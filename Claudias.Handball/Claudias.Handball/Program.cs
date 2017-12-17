using System;
using Claudias.Handball.Models;
using System.Collections.Generic;
using Claudias.Handball.Business.Core;

namespace Claudias.Handball
{
    class Program
    {       
        private static void ShowArticles(BusinessContext businessContext)
        {
            List<Article> articles = businessContext.ArticleBusiness.ReadAll();
            Console.WriteLine("Articles:");
            foreach (Article article in articles)
            {
             Console.WriteLine("{0} {1} {2} {3}", article.ArticleId,article.Title, article.Author,article.Description);
            }
        }
        private static void ReadByIdArticle(BusinessContext businessContext)
        {
            Article article = new Article();
            Article article2 = new Article();
            article.ArticleId = new Guid("86CA5305-18F6-4A15-65BC-AB12345DD124");
            article.Title = "VICTORIEEEEE";
            article.Author = "Marin MArin";
            article.Description = "vbgrtfd";
            article2 = businessContext.ArticleBusiness.ReadById(article.ArticleId);
            Console.WriteLine("{0} {1} {2} {3} ", article2.ArticleId, article2.Title, article2.Author, article2.Description);
        }

        private static void InsertArticle(BusinessContext businessContext)
        {
            Article article = new Article();
            Article article2 = new Article();
            article.ArticleId =new Guid("86CA5305-18F6-4A15-65BC-AB12345DD124");
            article.Title = "VICTORIEEEEE";
            article.Author = "Marin MArin";
            article.Description = "vbgrtfd";

            businessContext.ArticleBusiness.Insert(article);
        }

        private static void UpdateArticle(BusinessContext businessContext)
        {
            Article article = new Article();
            article.ArticleId = new Guid("86CA5305-18F6-4A15-65BC-AB12345DD124");
            article.Title = "lalaalalalalal";
            article.Author = "AAAAAAAAAAAAAAAAA";
            article.Description = "descitprion";
            businessContext.ArticleBusiness.Update(article);
        }
        private static void DeleteArticle(BusinessContext businessContext)
        {

            Article article = new Article();
            article.ArticleId = new Guid("86CA5305-18F6-4A15-65BC-AB12345DD124");
            article.Title = "lalaalalalalal";
            article.Author = "AAAAAAAAAAAAAAAAA";
            article.Description = "descitprion";

            businessContext.ArticleBusiness.Delete(article.ArticleId);
        }


        static void Main(string[] args)
        {
           

            using (BusinessContext businessContext = new BusinessContext())
            {
                ShowArticles(businessContext);
                InsertArticle(businessContext);
                ReadByIdArticle(businessContext);
                UpdateArticle(businessContext);
                ReadByIdArticle(businessContext);
                DeleteArticle(businessContext);
            
                Console.ReadKey();
            }
        }
    }
}

