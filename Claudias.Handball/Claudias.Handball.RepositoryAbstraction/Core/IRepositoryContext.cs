using System;

namespace Claudias.Handball.RepositoryAbstraction.Core
{
    public interface IRepositoryContext : IDisposable
    {
        IArticleRepository ArticleRepository { get; }
        IArticlePhotoRepository ArticlePhotoRepository { get; }
        INextEventRepository NextEventRepository { get; }
        IPhotoRepository PhotoRepository { get; }
        IPlayerPhotoRepository PlayerPhotoRepository { get; }
        IPlayerPositionRepository PlayerPositionRepository { get; }
        IPlayerRepository PlayerRepository { get; }
        IPositionRepository PositionRepository { get; }
        IUserRepository UserRepository { get; }
    }
}
