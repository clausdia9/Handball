using System;
using Claudias.Handball.Repository;
using Claudias.Handball.Models;
using System.Collections.Generic;
using System.Text;

namespace Claudias.Handball
{
    class Program
    {
       static void Main(string[] args)
        {
            ArticleRepository articleRepository = new ArticleRepository();

            Article article1 = new Article();
            article1.ArticleId = new Guid("86CA5305-18F6-4A15-65BC-AB12345DD123");
            article1.Title = "NEW WIN FOR THE TEAM";
            article1.Author = "Mary Koren";
            article1.Description = "ULl uvkrjn bgvrfd";

            
            articleRepository.Insert(article1);
            Article article2 = articleRepository.ReadById(article1.ArticleId);

            Console.WriteLine("{0} {1} {2} {3}", article2.ArticleId, article2.Title, article2.Author, article2.Description);

            articleRepository.Update(article1);
            articleRepository.Delete(article1);
            
           List<Article> articles = articleRepository.ReadAll();
            foreach (Article article in articles)
            {
              Console.WriteLine("{0} {1} {2} {3}", article.ArticleId,article.Title, article.Author,article.Description);
            }

            Console.ReadKey();
        }
    }
}

