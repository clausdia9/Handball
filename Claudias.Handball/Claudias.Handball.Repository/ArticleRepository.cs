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
        public List<Article> ReadById(SqlParameter parameter)
        {
            return ReadById("dbo.Articles_ReadById", parameter);
        }

        public void Insert(SqlParameter[] parameters = default(SqlParameter[]))
        {
             Insert("dbo.Articles_Create", parameters);
        }
        public void Update(SqlParameter[] parameters = default(SqlParameter[]))
        {
            Update("dbo.Articles_Update", parameters);
        }
        public void Delete(SqlParameter parameter)
        {
            Delete("dbo.Articles_Delete", parameter);
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
