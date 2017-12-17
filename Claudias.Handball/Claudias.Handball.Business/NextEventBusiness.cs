using Claudias.Handball.Business.Core;
using Claudias.Handball.Models;
using System;
using System.Collections.Generic;

namespace Claudias.Handball.Business
{
    public class NextEventBusiness
    {
        public List<NextEvent> ReadAll()
        {
            return BusinessContext.Current.RepositoryContext.NextEventRepository.ReadAll();
        }

        public NextEvent ReadById(Guid eventId)
        {
            return BusinessContext.Current.RepositoryContext.NextEventRepository.ReadById(eventId);
        }

        public void Insert(NextEvent nextEvent)
        {
            BusinessContext.Current.RepositoryContext.NextEventRepository.Insert(nextEvent);
        }

        public void Update(NextEvent nextEvent)
        {
            BusinessContext.Current.RepositoryContext.NextEventRepository.Update(nextEvent);
        }

        public void Delete(Guid eventId)
        {
            BusinessContext.Current.RepositoryContext.NextEventRepository.Delete(eventId);
        }
    }
}
