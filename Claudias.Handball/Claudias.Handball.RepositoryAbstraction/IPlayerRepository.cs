using Claudias.Handball.Models;
using System;
using System.Collections.Generic;

namespace Claudias.Handball.RepositoryAbstraction
{
    public interface IPlayerRepository
    {
        List<Player> ReadAll();
        Player ReadById(Guid playerId);
        void Insert(Player player);
        void Update(Player player);
        void Delete(Guid playerId);
    }
}
