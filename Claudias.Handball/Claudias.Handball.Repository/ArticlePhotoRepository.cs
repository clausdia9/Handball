using Claudias.Handball.Models;
using System.Data.SqlClient;
using Claudias.Handball.Repository.Core;
using Claudias.Handball.RepositoryAbstraction;

namespace Claudias.Handball.Repository
{
    public class ArticlePhotoRepository:BaseRepository<ArticlePhoto>,IArticlePhotoRepository
    {

        #region Methods
        public void Insert(ArticlePhoto articlePhoto)
        {
            SqlParameter[] parameters = {new SqlParameter("@ArticleID",articlePhoto.ArticleId),
                                         new SqlParameter("@PhotoID", articlePhoto.PhotoId)};
            ExecuteNonQuery("dbo.ArticlesPhotos_Create", parameters);
        }
        
        public void Delete(ArticlePhoto articlePhoto)
        {
            SqlParameter[] parameters = {new SqlParameter("@ArticleID",articlePhoto.ArticleId),
                                         new SqlParameter("@PhotoID", articlePhoto.PhotoId)};
            ExecuteNonQuery("dbo.ArticlesPhotos_Delete", parameters);
        }

        protected override ArticlePhoto GetModelFromReader(SqlDataReader reader)
        {
            ArticlePhoto articlePhoto = new ArticlePhoto();
            articlePhoto.ArticleId = reader.GetGuid(reader.GetOrdinal("ArticleID"));
            articlePhoto.PhotoId = reader.GetGuid(reader.GetOrdinal("PhotoID"));
            return articlePhoto;
        }
        #endregion Methods
    }
}
