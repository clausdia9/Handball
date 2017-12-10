using Claudias.Handball.Models;
using Claudias.Handball.Repository.Core;
using System.Data.SqlClient;

namespace Claudias.Handball.Repository
{
    public class PlayerPhotoRepository:BaseRepository<PlayerPhoto>
    {

        #region Methods
        public void Insert(SqlParameter[] parameters = default(SqlParameter[]))
        {
            Modify("dbo.PlayersPhotos_Create", parameters);
        }

        public void Delete(SqlParameter[] parameters)
        {
            Modify("dbo.PlayersPhotos_Delete", parameters);
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
