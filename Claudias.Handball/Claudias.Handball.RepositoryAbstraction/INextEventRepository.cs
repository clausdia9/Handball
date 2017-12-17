using Claudias.Handball.Models;
using System;
using System.Collections.Generic;

namespace Claudias.Handball.RepositoryAbstraction
{
    public interface INextEventRepository
    {
        List<NextEvent> ReadAll();
        NextEvent ReadById(Guid eventId);
        void Insert(NextEvent nextEvent);
        void Update(NextEvent nextEvent);
        void Delete(Guid nextEventId);
    }
}
