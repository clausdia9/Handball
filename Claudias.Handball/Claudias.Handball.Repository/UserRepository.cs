using Claudias.Handball.Models;
using Claudias.Handball.Repository.Core;
using Claudias.Handball.RepositoryAbstraction;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Claudias.Handball.Repository
{
    public class UserRepository:BaseRepository<User>,IUserRepository
    {

        #region Methods
        public List<User> ReadAll()
        {
            return ReadAll("dbo.Users_ReadAll");
        }

        public User ReadById(Guid userId)
        {
            SqlParameter[] parameter = {new SqlParameter("@UserID",userId) };
            return ReadAll("dbo.Users_ReadById", parameter).Single();
        }

        public void Insert(User user)
        {
            SqlParameter[] parameters = {new SqlParameter("@UserID",user.UserId),
                                         new SqlParameter("@UserName",user.UserName),
                                         new SqlParameter("@Password",user.Password),
                                         new SqlParameter("@UserType",user.UserType)};
            ExecuteNonQuery("dbo.Users_Create", parameters);
        }

        public void Update(User user)
        {
            SqlParameter[] parameters = {new SqlParameter("@UserID",user.UserId),
                                         new SqlParameter("@UserName",user.UserName),
                                         new SqlParameter("@Password",user.Password),
                                         new SqlParameter("@UserType",user.UserType)};
            ExecuteNonQuery("dbo.Users_Update", parameters);
        }

        public void Delete(Guid userId)
        {
            SqlParameter[] parameter = { new SqlParameter("@UserID", userId) };
            ExecuteNonQuery("dbo.Users_Delete", parameter);
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
