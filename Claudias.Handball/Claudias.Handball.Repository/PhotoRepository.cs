using Claudias.Handball.Models;
using Claudias.Handball.Repository.Core;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Claudias.Handball.Repository
{
    public class PhotoRepository:BaseRepository<Photo>
    {

        #region Methods
        public List<Photo> ReadAll()
        {
            return ReadAll("dbo.Photos_ReadAll");
        }
        public List<Photo> ReadById(SqlParameter[] parameters)
        {
            return ReadAll("dbo.Photos_ReadById", parameters);
        }

        public void Insert(SqlParameter[] parameters = default(SqlParameter[]))
        {
            Modify("dbo.Photos_Create", parameters);
        }
        public void Update(SqlParameter[] parameters = default(SqlParameter[]))
        {
            Modify("dbo.Photos_Update", parameters);
        }
        public void Delete(SqlParameter[] parameters)
        {
            Modify("dbo.Photos_Delete", parameters);
        }
        protected override Photo GetModelFromReader (SqlDataReader reader)
        {
            Photo photo = new Photo();
            photo.PhotoId = reader.GetGuid(reader.GetOrdinal("PhotoID"));
            photo.PhotoVarbinary = (byte[])reader["PhotoVarbinary"];
            return photo;

        }
        #endregion
    }
}
