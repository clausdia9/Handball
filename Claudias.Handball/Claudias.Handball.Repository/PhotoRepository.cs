using Claudias.Handball.Models;
using Claudias.Handball.Repository.Core;
using System;
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
        public List<Photo> ReadById(SqlParameter parameter)
        {
            return ReadById("dbo.Photos_ReadById", parameter);
        }

        public void Insert(SqlParameter[] parameters = default(SqlParameter[]))
        {
            Insert("dbo.Photos_Create", parameters);
        }
        public void Update(SqlParameter[] parameters = default(SqlParameter[]))
        {
            Update("dbo.Photos_Update", parameters);
        }
        public void Delete(SqlParameter parameter)
        {
            Delete("dbo.Photos_Delete", parameter);
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
