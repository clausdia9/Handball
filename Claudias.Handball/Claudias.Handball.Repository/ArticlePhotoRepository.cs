using Claudias.Handball.Models;
using System.Data.SqlClient;
using Claudias.Handball.Repository.Core;

namespace Claudias.Handball.Repository
{
    public class ArticlePhotoRepository:BaseRepository<ArticlePhoto>
    {

        #region Methods
       
        

        public void Insert(SqlParameter[] parameters = default(SqlParameter[]))
        {
            Insert("dbo.ArticlesPhotos_Create", parameters);
        }
        
        public void Delete(SqlParameter parameter)
        {
            Delete("dbo.ArticlesPhotos_Delete", parameter);
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
