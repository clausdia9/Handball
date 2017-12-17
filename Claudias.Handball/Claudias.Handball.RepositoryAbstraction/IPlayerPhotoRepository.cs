using Claudias.Handball.Models;

namespace Claudias.Handball.RepositoryAbstraction
{
    public interface IPlayerPhotoRepository
    {
        void Insert(PlayerPhoto playerPhoto);
        void Delete(PlayerPhoto playerPhoto);
    }
}
