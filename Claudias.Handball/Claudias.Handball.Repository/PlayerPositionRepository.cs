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
            Insert("dbo.PlayersPositions_Create", parameters);
        }

        public void Delete(SqlParameter parameter)
        {
            Delete("dbo.PlayersPositions_Delete", parameter);
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
