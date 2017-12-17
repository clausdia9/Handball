using Claudias.Handball.Models;

namespace Claudias.Handball.RepositoryAbstraction
{
    public interface IPlayerPositionRepository
    {
        void Insert(PlayerPosition playerPosition);
        void Delete(PlayerPosition playerPosition);
    }
}
