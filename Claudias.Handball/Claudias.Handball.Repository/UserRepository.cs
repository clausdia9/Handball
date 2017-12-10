using Claudias.Handball.Models;
using Claudias.Handball.Repository.Core;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Claudias.Handball.Repository
{
    public class UserRepository:BaseRepository<User>
    {

        #region Methods
        public List<User> ReadAll()
        {
            return ReadAll("dbo.Users_ReadAll");
        }
        public List<User> ReadById(SqlParameter[] parameters)
        {
            return ReadAll("dbo.Users_ReadById", parameters);
        }

        public void Insert(SqlParameter[] parameters = default(SqlParameter[]))
        {
            Modify("dbo.Users_Create", parameters);
        }
        public void Update(SqlParameter[] parameters = default(SqlParameter[]))
        {
            Modify("dbo.Users_Update", parameters);
        }
        public void Delete(SqlParameter[] parameters)
        {
            Modify("dbo.Users_Delete", parameters);
        }
        protected override User GetModelFromReader(SqlDataReader reader)
        {
            User user = new User();
            user.UserId = reader.GetGuid(reader.GetOrdinal("UserID"));
            user.UserName = reader.GetString(reader.GetOrdinal("UserName"));
            user.Password = reader.GetString(reader.GetOrdinal("Password"));
            user.UserType = reader.GetString(reader.GetOrdinal("UserType"));
            return user;

        }
        #endregion Methods
    }
}
