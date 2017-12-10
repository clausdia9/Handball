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
        public List<Player> ReadById(SqlParameter[] parameters)
        {
            return ReadAll("dbo.Players_ReadById", parameters);
        }

        public void Insert(SqlParameter[] parameters = default(SqlParameter[]))
        {
            Modify("dbo.Players_Create", parameters);
        }
        public void Update(SqlParameter[] parameters = default(SqlParameter[]))
        {
            Modify("dbo.Players_Update", parameters);
        }
        public void Delete(SqlParameter[] parameters)
        {
            Modify("dbo.Players_Delete", parameters);
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
