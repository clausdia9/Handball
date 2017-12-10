using Claudias.Handball.Models;
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
            public List<NextEvent> ReadById(SqlParameter[] parameters)
            {
                return ReadAll("dbo.NextEvents_ReadById", parameters);
            }

            public void Insert(SqlParameter[] parameters = default(SqlParameter[]))
            {
                Modify("dbo.NextEvents_Create", parameters);
            }
            public void Update(SqlParameter[] parameters = default(SqlParameter[]))
            {
                Modify("dbo.NextEvents_Update", parameters);
            }
            public void Delete(SqlParameter[] parameters)
            {
                Modify("dbo.NextEvents_Delete", parameters);
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