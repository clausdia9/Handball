using Claudias.Handball.Business.Core;
using Claudias.Handball.Models;

namespace Claudias.Handball.Business
{
    public class PlayerPositionBusiness
    {
        public void Insert(PlayerPosition playerPosition)
        {
            BusinessContext.Current.RepositoryContext.PlayerPositionRepository.Insert(playerPosition);
        }

        public void Delete(PlayerPosition playerPosition)
        {
            BusinessContext.Current.RepositoryContext.PlayerPositionRepository.Delete(playerPosition);
        }
    }
}
