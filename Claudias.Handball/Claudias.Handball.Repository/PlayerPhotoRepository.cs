using Claudias.Handball.Models;
using Claudias.Handball.Repository.Core;
using System;
using System.Data.SqlClient;

namespace Claudias.Handball.Repository
{
    public class PlayerPhotoRepository:BaseRepository<PlayerPhoto>
    {

        #region Methods
        public void Insert(SqlParameter[] parameters = default(SqlParameter[]))
        {
            Insert("dbo.PlayersPhotos_Create", parameters);
        }

        public void Delete(SqlParameter parameter)
        {
            Delete("dbo.PlayersPhotos_Delete", parameter);
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
