using Claudias.Handball.Models;
using Claudias.Handball.Repository.Core;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Claudias.Handball.Repository
{
    public class PlayerRepository:BaseRepository<Player>
    {

        #region Methods
        public List<Player> ReadAll()
        {
            return ReadAll("dbo.Players_ReadAll");
        }
        public List<Player> ReadById(SqlParameter parameter)
        {
            return ReadById("dbo.Players_ReadById", parameter);
        }

        public void Insert(SqlParameter[] parameters = default(SqlParameter[]))
        {
            Insert("dbo.Players_Create", parameters);
        }
        public void Update(SqlParameter[] parameters = default(SqlParameter[]))
        {
            Update("dbo.Players_Update", parameters);
        }
        public void Delete(SqlParameter parameter)
        {
            Delete("dbo.Players_Delete", parameter);
        }
        protected override Player GetModelFromReader(SqlDataReader reader)
        {
            Player player = new Player();
            player.PlayerId = reader.GetGuid(reader.GetOrdinal("PlayerID"));
            player.PlayerName = reader.GetString(reader.GetOrdinal("PlayerName"));
            player.Goals = reader.GetInt32(reader.GetOrdinal("Goals"));
            player.BirthDay = reader.GetDateTime(reader.GetOrdinal("BirthDay"));
            return player;

        }
        #endregion Methods
    }
}
