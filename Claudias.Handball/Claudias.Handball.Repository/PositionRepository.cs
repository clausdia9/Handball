using Claudias.Handball.Models;
using Claudias.Handball.Repository.Core;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Claudias.Handball.Repository
{
    public class PositionRepository:BaseRepository<Position>
    {

        #region Methods
        public List<Position> ReadAll()
        {
            return ReadAll("dbo.Positions_ReadAll");
        }
        public List<Position> ReadById(SqlParameter parameter)
        {
            return ReadById("dbo.Positions_ReadById", parameter);
        }

        public void Insert(SqlParameter[] parameters = default(SqlParameter[]))
        {
            Insert("dbo.Positions_Create", parameters);
        }
        public void Update(SqlParameter[] parameters = default(SqlParameter[]))
        {
            Update("dbo.Positions_Update", parameters);
        }
        public void Delete(SqlParameter parameter)
        {
            Delete("dbo.Positions_Delete", parameter);
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
