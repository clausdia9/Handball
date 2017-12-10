using Claudias.Handball.Models;
using Claudias.Handball.Repository.Core;
using System.Collections.Generic;
using System.Data.SqlClient;
using System;

namespace Claudias.Handball.Repository
{
    public class ArticleRepository:BaseRepository<Article>
    {

        #region Methods
       public List<Article> ReadAll()
        {
            return ReadAll("dbo.Articles_ReadAll");
        }
        public List<Article> ReadById(SqlParameter[] parameters)
        {
            return ReadAll("dbo.Articles_ReadById", parameters);
        }

        public void Insert(SqlParameter[] parameters = default(SqlParameter[]))
        {
             Modify("dbo.Articles_Create", parameters);
        }
        public void Update(SqlParameter[] parameters = default(SqlParameter[]))
        {
            Modify("dbo.Articles_Update", parameters);
        }
        public void Delete(SqlParameter[] parameters)
        {
            Modify("dbo.Articles_Delete", parameters);
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
