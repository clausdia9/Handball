using Claudias.Handball.Models;
using Claudias.Handball.Repository.Core;
using Claudias.Handball.RepositoryAbstraction;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Claudias.Handball.Repository
{
    public class PositionRepository:BaseRepository<Position>,IPositionRepository
    {

        #region Methods
        public List<Position> ReadAll()
        {
            return ReadAll("dbo.Positions_ReadAll");
        }

        public Position ReadById(Guid positionId)
        {
            SqlParameter[] parameter = {new SqlParameter("@PositionID",positionId)};
            return ReadAll("dbo.Positions_ReadById", parameter).Single();
        }

        public void Insert(Position position)
        {
            SqlParameter[] parameters = {new SqlParameter("@PositionID",position.PositionId),
                                         new SqlParameter("@PositionName", position.PositionName)};
            ExecuteNonQuery("dbo.Positions_Create", parameters);
        }

        public void Update(Position position)
        {
            SqlParameter[] parameters = {new SqlParameter("@PositionID",position.PositionId),
                                         new SqlParameter("@PositionName", position.PositionName)};
            ExecuteNonQuery("dbo.Positions_Update", parameters);
        }

        public void Delete(Guid positionId)
        {
            SqlParameter[] parameter = {new SqlParameter("@PositionID",positionId) };
            ExecuteNonQuery("dbo.Positions_Delete", parameter);
        }

        protected override Position GetModelFromReader(SqlDataReader reader)
        {
            Position position = new Position();
            position.PositionId = reader.GetGuid(reader.GetOrdinal("PositionID"));
            position.PositionName = reader.GetString(reader.GetOrdinal("PositionName"));
            return position;

        }
        #endregion Methods
    }
}
