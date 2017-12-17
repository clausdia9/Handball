using Claudias.Handball.Models;
using Claudias.Handball.Repository.Core;
using Claudias.Handball.RepositoryAbstraction;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Claudias.Handball.Repository
{
    public class PlayerRepository:BaseRepository<Player>,IPlayerRepository
    {

        #region Methods
        public List<Player> ReadAll()
        {
            return ReadAll("dbo.Players_ReadAll");
        }

        public Player ReadById(Guid playerId)
        {
            SqlParameter[] parameters = { new SqlParameter("@PlayerID", playerId) };
            return ReadAll("dbo.Players_ReadById", parameters).Single();
        }

        public void Insert(Player player)
        {
            SqlParameter[] parameters = {new SqlParameter("@PlayerID",player.PlayerId),
                                         new SqlParameter("@PlayerName",player.PlayerName),
                                         new SqlParameter("@Goals",player.Goals),
                                         new SqlParameter("@BirthDay",player.BirthDay)};
            ExecuteNonQuery("dbo.Players_Create", parameters);
        }
        public void Update(Player player)
        {
            SqlParameter[] parameters = {new SqlParameter("@PlayerID",player.PlayerId),
                                         new SqlParameter("@PlayerName",player.PlayerName),
                                         new SqlParameter("@Goals",player.Goals),
                                         new SqlParameter("@BirthDay",player.BirthDay)};
            ExecuteNonQuery("dbo.Players_Update", parameters);
        }

        public void Delete(Guid playerId)
        {
            SqlParameter[] parameters = { new SqlParameter("@PlayerID", playerId) };
            ExecuteNonQuery("dbo.Players_Delete", parameters);
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
