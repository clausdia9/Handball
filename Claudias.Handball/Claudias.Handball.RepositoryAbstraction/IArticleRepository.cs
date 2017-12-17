using Claudias.Handball.Models;
using System;
using System.Collections.Generic;

namespace Claudias.Handball.RepositoryAbstraction
{
    public interface IArticleRepository
    {
        List<Article> ReadAll();
        Article ReadById(Guid articleId);
        void Insert(Article article);
        void Update(Article article);
        void Delete(Guid articleId);
    }
}
