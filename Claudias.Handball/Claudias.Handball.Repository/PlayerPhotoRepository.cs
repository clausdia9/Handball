using Claudias.Handball.Models;
using Claudias.Handball.Repository.Core;
using Claudias.Handball.RepositoryAbstraction;
using System.Data.SqlClient;

namespace Claudias.Handball.Repository
{
    public class PlayerPhotoRepository:BaseRepository<PlayerPhoto>,IPlayerPhotoRepository
    {

        #region Methods
        public void Insert(PlayerPhoto playerPhoto)
        {
            SqlParameter[] parameters = { new SqlParameter("@PlayerID",playerPhoto.PlayerId),
                                          new SqlParameter("@PhotoID",playerPhoto.PhotoId)};
            ExecuteNonQuery("dbo.PlayersPhotos_Create", parameters);
        }

        public void Delete(PlayerPhoto playerPhoto)
        {
            SqlParameter[] parameters = { new SqlParameter("@PlayerID",playerPhoto.PlayerId),
                                          new SqlParameter("@PhotoID",playerPhoto.PhotoId)};
            ExecuteNonQuery("dbo.PlayersPhotos_Delete", parameters);
        }

        protected override PlayerPhoto GetModelFromReader(SqlDataReader reader)
        {
            PlayerPhoto playerPhoto = new PlayerPhoto();
            playerPhoto.PlayerId= reader.GetGuid(reader.GetOrdinal("PlayerID"));
            playerPhoto.PlayerId = reader.GetGuid(reader.GetOrdinal("PhotoID"));
            return playerPhoto;
        }
        #endregion Methods
    }
}
