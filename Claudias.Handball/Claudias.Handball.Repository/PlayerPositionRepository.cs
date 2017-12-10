using Claudias.Handball.Models;
using Claudias.Handball.Repository.Core;
using System.Data.SqlClient;

namespace Claudias.Handball.Repository
{
    public class PlayerPositionRepository:BaseRepository<PlayerPosition>
    {

        #region Methods
        public void Insert(SqlParameter[] parameters = default(SqlParameter[]))
        {
            Modify("dbo.PlayersPositions_Create", parameters);
        }

        public void Delete(SqlParameter[] parameters)
        {
            Modify("dbo.PlayersPositions_Delete", parameters);
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
