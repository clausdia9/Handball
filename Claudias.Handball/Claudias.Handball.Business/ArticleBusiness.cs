using Claudias.Handball.Business.Core;
using Claudias.Handball.Models;
using System;
using System.Collections.Generic;

namespace Claudias.Handball.Business
{
    public class ArticleBusiness
    {
        public List<Article> ReadAll()
        {
            return BusinessContext.Current.RepositoryContext.ArticleRepository.ReadAll();
        }

        public Article ReadById(Guid articleId)
        {
            return BusinessContext.Current.RepositoryContext.ArticleRepository.ReadById(articleId);
        }

        public void Insert(Article article)
        {
            BusinessContext.Current.RepositoryContext.ArticleRepository.Insert(article);
        }

        public void Update(Article article)
        {
            BusinessContext.Current.RepositoryContext.ArticleRepository.Update(article);
        }

        public void Delete(Guid articleId)
        {
            BusinessContext.Current.RepositoryContext.ArticleRepository.Delete(articleId);
        }
    }
}
