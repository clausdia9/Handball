using Claudias.Handball.Business.Core;
using Claudias.Handball.Models;
using System;
using System.Collections.Generic;

namespace Claudias.Handball.Business
{
    public class PlayerBusiness
    {
        public List<Player> ReadAll()
        {
            return BusinessContext.Current.RepositoryContext.PlayerRepository.ReadAll();
        }

        public Player ReadById(Guid playerId)
        {
            return BusinessContext.Current.RepositoryContext.PlayerRepository.ReadById(playerId);
        }

        public void Insert(Player player)
        {
            BusinessContext.Current.RepositoryContext.PlayerRepository.Insert(player);
        }

        public void Update(Player player)
        {
            BusinessContext.Current.RepositoryContext.PlayerRepository.Update(player);
        }

        public void Delete(Guid playerId)
        {
            BusinessContext.Current.RepositoryContext.PlayerRepository.Delete(playerId);
        }
    }
}
