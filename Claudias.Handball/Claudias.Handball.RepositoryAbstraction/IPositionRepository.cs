using Claudias.Handball.Models;
using System;
using System.Collections.Generic;

namespace Claudias.Handball.RepositoryAbstraction
{
    public interface IPositionRepository
    {
        List<Position> ReadAll();
        Position ReadById(Guid positionId);
        void Insert(Position position);
        void Update(Position position);
        void Delete(Guid positionId);
    }
}
