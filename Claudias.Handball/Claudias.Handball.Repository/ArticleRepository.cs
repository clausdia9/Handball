using Claudias.Handball.Models;
using Claudias.Handball.Repository.Core;
using System.Collections.Generic;
using System.Data.SqlClient;
using System;
using System.Linq;
using Claudias.Handball.RepositoryAbstraction;

namespace Claudias.Handball.Repository
{
    public class ArticleRepository:BaseRepository<Article>,IArticleRepository
    {

        #region Methods
       public List<Article> ReadAll()
        {
            return ReadAll("dbo.Articles_ReadAll");
        }
        public Article ReadById(Guid articleId)
        {
            SqlParameter[] parameter = { new SqlParameter("@ArticleID", articleId) };
            return ReadAll("dbo.Articles_ReadById", parameter).Single();
        }

        public void Insert(Article article)
        {
            SqlParameter[] parameters = {new SqlParameter("@ArticleID",article.ArticleId),
                                         new SqlParameter("@Title",article.Title),
                                         new SqlParameter("@Author",article.Author),
                                         new SqlParameter("@Description",article.Description)};
            ExecuteNonQuery("dbo.Articles_Create", parameters);
        }

        public void Update(Article article)
        {
            SqlParameter[] parameters = {new SqlParameter("@ArticleID",article.ArticleId),
                                         new SqlParameter("@Title",article.Title),
                                         new SqlParameter("@Author",article.Author),
                                         new SqlParameter("@Description",article.Description)};
            ExecuteNonQuery("dbo.Articles_Update", parameters);
        }

        public void Delete(Guid articleId)
        {
            SqlParameter[] parameter = { new SqlParameter("@ArticleID", articleId) } ;
            ExecuteNonQuery("dbo.Articles_Delete", parameter);
        }

        protected override Article GetModelFromReader(SqlDataReader reader)
        {
            Article article = new Article();
            article.ArticleId = reader.GetGuid(reader.GetOrdinal("ArticleID"));
            article.Title = reader.GetString(reader.GetOrdinal("Title"));
            article.Author = reader.GetString(reader.GetOrdinal("Author"));
            article.Description = reader.GetString(reader.GetOrdinal("Description"));
            return article;

        }
        #endregion Methods
    }
}
