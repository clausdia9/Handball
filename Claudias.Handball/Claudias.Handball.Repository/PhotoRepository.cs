using Claudias.Handball.Models;
using Claudias.Handball.Repository.Core;
using Claudias.Handball.RepositoryAbstraction;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Claudias.Handball.Repository
{
    public class PhotoRepository:BaseRepository<Photo>,IPhotoRepository
    {

        #region Methods
        public List<Photo> ReadAll()
        {
            return ReadAll("dbo.Photos_ReadAll");
        }

        public Photo ReadById(Guid photoId)
        {
            SqlParameter[] parameters = { new SqlParameter("@PhotoID", photoId) };
            return ReadAll("dbo.Photos_ReadById", parameters).Single();
        }

        public void Insert(Photo photo)
        {
            SqlParameter[] parameters = {new SqlParameter("@PhotoID",photo.PhotoId),
                                         new SqlParameter("@PhotoVarbinary",photo.PhotoVarbinary)};
            ExecuteNonQuery("dbo.Photos_Create", parameters);
        }

        public void Update(Photo photo)
        {
            SqlParameter[] parameters = {new SqlParameter("@PhotoID",photo.PhotoId),
                                         new SqlParameter("@PhotoVarbinary",photo.PhotoVarbinary)};
            ExecuteNonQuery("dbo.Photos_Update", parameters);
        }

        public void Delete(Guid photoId)
        {
            SqlParameter[] parameter = { new SqlParameter("@PhotoID", photoId) };
            ExecuteNonQuery("dbo.Photos_Delete", parameter);
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
