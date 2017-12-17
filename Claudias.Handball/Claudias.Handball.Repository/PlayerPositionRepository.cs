using Claudias.Handball.Models;
using Claudias.Handball.Repository.Core;
using Claudias.Handball.RepositoryAbstraction;
using System.Data.SqlClient;

namespace Claudias.Handball.Repository
{
    public class PlayerPositionRepository:BaseRepository<PlayerPosition>,IPlayerPositionRepository
    {

        #region Methods
        public void Insert(PlayerPosition playerPosition)
        {
            SqlParameter[] parameters = { new SqlParameter("@PlayerID",playerPosition.PlayerId),
                                          new SqlParameter("@PositionID",playerPosition.PositionId)};
            ExecuteNonQuery("dbo.PlayersPositions_Create", parameters);
        }

        public void Delete(PlayerPosition playerPosition)
        {
            SqlParameter[] parameters = { new SqlParameter("@PlayerID",playerPosition.PlayerId),
                                          new SqlParameter("@PositionID",playerPosition.PositionId)};
            ExecuteNonQuery("dbo.PlayersPositions_Delete", parameters);
        }

        protected override PlayerPosition GetModelFromReader(SqlDataReader reader)
        {
            PlayerPosition playerPosition = new PlayerPosition();
            playerPosition.PlayerId = reader.GetGuid(reader.GetOrdinal("PlayerID"));
            playerPosition.PositionId = reader.GetGuid(reader.GetOrdinal("PositionID"));
            return playerPosition;
        }
        #endregion Methods
    }
}
