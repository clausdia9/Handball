using Claudias.Handball.Business.Core;
using Claudias.Handball.Models;

namespace Claudias.Handball.Business
{
    public class PlayerPhotoBusiness
    {
        public void Insert(PlayerPhoto playerPhoto)
        {
            BusinessContext.Current.RepositoryContext.PlayerPhotoRepository.Insert(playerPhoto);
        }

        public void Delete(PlayerPhoto playerPhoto)
        {
            BusinessContext.Current.RepositoryContext.PlayerPhotoRepository.Delete(playerPhoto);
        }
    }
}
