using Claudias.Handball.RepositoryAbstraction;
using Claudias.Handball.RepositoryAbstraction.Core;
using System;

namespace Claudias.Handball.Repository.Core
{
    public class RepositoryContext : IRepositoryContext
    {
        #region Members
        private static IRepositoryContext _instance;
        
        private IArticleRepository _articleRepository;
        private IArticlePhotoRepository _articlePhotoRepository;
        private INextEventRepository _nextEventRepository;
        private IPhotoRepository _photoRepository;
        private IPlayerPhotoRepository _playerPhotoRepository;
        private IPlayerPositionRepository _playerPositionRepository;
        private IPlayerRepository _playerRepository;
        private IPositionRepository _positionRepository;
        private IUserRepository _userRepository;
        #endregion

        #region Constructor
        public RepositoryContext()
        {
            _instance = this;
        }
        #endregion

        #region Properties
        internal static IRepositoryContext Current
        {
            get
            {
                if (_instance == null)
                {
                    throw new Exception("No RepositoryContext instance available!");
                }
                return _instance;
            }
        }

        public IArticleRepository ArticleRepository
        {
            get
            {
                if (_articleRepository == null)
                    _articleRepository = new ArticleRepository();
                return _articleRepository;
            }
        }

        public IArticlePhotoRepository ArticlePhotoRepository
        {
            get
            {
                if (_articlePhotoRepository == null)
                    _articlePhotoRepository = new ArticlePhotoRepository();
                return _articlePhotoRepository;
            }
        }

        public INextEventRepository NextEventRepository
        {
            get
            {
                if (_nextEventRepository == null)
                    _nextEventRepository = new NextEventRepository();
                return _nextEventRepository;
            }
        }

        public IPhotoRepository PhotoRepository
        {
            get
            {
                if (_photoRepository == null)
                    _photoRepository = new PhotoRepository();
                return _photoRepository;
            }
        }

        public IPlayerPhotoRepository PlayerPhotoRepository
        {
            get
            {
                if (_playerPhotoRepository == null)
                    _playerPhotoRepository = new PlayerPhotoRepository();
                return _playerPhotoRepository;
            }
        }

        public IPlayerPositionRepository PlayerPositionRepository
        {
            get
            {
                if (_playerPositionRepository == null)
                    _playerPositionRepository = new PlayerPositionRepository();
                return _playerPositionRepository;
            }
        }

        public IPlayerRepository PlayerRepository
        {
            get
            {
                if (_playerRepository == null)
                    _playerRepository = new PlayerRepository();
                return _playerRepository;
            }
        }

        public IPositionRepository PositionRepository
        {
            get
            {
                if (_positionRepository == null)
                    _positionRepository = new PositionRepository();
                return _positionRepository;
            }
        }

        public IUserRepository UserRepository
        {
            get
            {
                if (_userRepository == null)
                    _userRepository = new UserRepository();
                return _userRepository;
            }
        }
        #endregion

        #region IDisposable Implementation
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool dispose)
        {
            if (dispose)
            {
                if (_articleRepository != null)
                {

                    _articleRepository = null;
                }

                if (_articlePhotoRepository != null)
                {

                    _articlePhotoRepository = null;
                }

                if (_nextEventRepository != null)
                {
                    _nextEventRepository = null;
                }

                if (_photoRepository != null)
                {
                    _photoRepository = null;
                }

                if (_playerPhotoRepository != null)
                {
                    _playerPhotoRepository = null;
                }

                if (_playerPositionRepository != null)
                {
                    _playerPositionRepository = null;
                }

                if(_playerRepository!=null)
                {
                    _playerRepository = null;
                }

                if (_positionRepository != null)
                {
                    _positionRepository = null;
                }

                if (_userRepository != null)
                {
                    _userRepository = null;
                }
            }
        }

        ~RepositoryContext()
        {
            Dispose(false);
        }
        #endregion
    }
}
