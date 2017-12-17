using Claudias.Handball.Business.Core;
using Claudias.Handball.Models;
using System;
using System.Collections.Generic;

namespace Claudias.Handball.Business
{
    public class PositionBusiness
    {
        public List<Position> ReadAll()
        {
            return BusinessContext.Current.RepositoryContext.PositionRepository.ReadAll();
        }

        public Position ReadById(Guid positionId)
        {
            return BusinessContext.Current.RepositoryContext.PositionRepository.ReadById(positionId);
        }

        public void Insert(Position position)
        {
            BusinessContext.Current.RepositoryContext.PositionRepository.Insert(position);
        }

        public void Update(Position position)
        {
            BusinessContext.Current.RepositoryContext.PositionRepository.Update(position);
        }

        public void Delete(Guid positionId)
        {
            BusinessContext.Current.RepositoryContext.PositionRepository.Delete(positionId);
        }
    }
}
