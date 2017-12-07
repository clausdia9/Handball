using Claudias.Handball.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Claudias.Handball.Repository.Core;
        
namespace Claudias.Handball.Repository
    {
        
        public class NextEventRepository : BaseRepository<NextEvent>
        {

            #region Methods
            public List<NextEvent> ReadAll()
            {
                return ReadAll("dbo.NextEvents_ReadAll");
            }
            public List<NextEvent> ReadById(SqlParameter parameter)
            {
                return ReadById("dbo.NextEvents_ReadById", parameter);
            }

            public void Insert(SqlParameter[] parameters = default(SqlParameter[]))
            {
                Insert("dbo.NextEvents_Create", parameters);
            }
            public void Update(SqlParameter[] parameters = default(SqlParameter[]))
            {
                Update("dbo.NextEvents_Update", parameters);
            }
            public void Delete(SqlParameter parameter)
            {
                Delete("dbo.NextEvents_Delete", parameter);
            }
            protected override NextEvent GetModelFromReader(SqlDataReader reader)
            {
            NextEvent nextEvent = new NextEvent();
            nextEvent.EventId = reader.GetGuid(reader.GetOrdinal("EventID"));
            nextEvent.EventName = reader.GetString(reader.GetOrdinal("EventName"));
            nextEvent.Location = reader.GetString(reader.GetOrdinal("Location"));
            nextEvent.Date = reader.GetDateTime(reader.GetOrdinal("Date"));
            return nextEvent;

        }
        #endregion Methods
    }
}