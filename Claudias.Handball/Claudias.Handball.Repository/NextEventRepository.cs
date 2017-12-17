using Claudias.Handball.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using Claudias.Handball.Repository.Core;
using System.Linq;
using System;
using Claudias.Handball.RepositoryAbstraction;

namespace Claudias.Handball.Repository
    {
        public class NextEventRepository : BaseRepository<NextEvent>,INextEventRepository
        {
            #region Methods
            public List<NextEvent> ReadAll()
            {
                return ReadAll("dbo.NextEvents_ReadAll");
            }

            public NextEvent ReadById(Guid eventId)
            {
            SqlParameter[] parameter = { new SqlParameter("@EventID",eventId) };
                return ReadAll("dbo.NextEvents_ReadById", parameter).Single();
            }

            public void Insert(NextEvent nextEvent)
            {
                SqlParameter[] parameters = {new SqlParameter("@EventID",nextEvent.EventId),
                                             new SqlParameter("@EventName",nextEvent.EventName),
                                             new SqlParameter("@Location",nextEvent.Location),
                                             new SqlParameter("@Date",nextEvent.Date)};
                ExecuteNonQuery("dbo.NextEvents_Create", parameters);
            }

            public void Update(NextEvent nextEvent)
            {
                SqlParameter[] parameters = {new SqlParameter("@EventID",nextEvent.EventId),
                                             new SqlParameter("@EventName",nextEvent.EventName),
                                             new SqlParameter("@Location",nextEvent.Location),
                                             new SqlParameter("@Date",nextEvent.Date)};
                ExecuteNonQuery("dbo.NextEvents_Update", parameters);
            }

            public void Delete(Guid nextEventId)
            {
                SqlParameter[] parameter = { new SqlParameter("@EventID", nextEventId) };
                ExecuteNonQuery("dbo.NextEvents_Delete", parameter);
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