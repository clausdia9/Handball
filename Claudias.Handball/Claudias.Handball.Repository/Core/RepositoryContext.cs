using System;

namespace Claudias.Handball.Repository.Core
{
    public class RepositoryContext : IDisposable
    {
        #region Members
        private ArticleRepository _articleRepository;
        private ArticlePhotoRepository _articlePhotoRepository;
        private NextEventRepository _nextEventRepository;
        private PhotoRepository _photoRepository;
        private PlayerPhotoRepository _playerPhotoRepository;
        private PlayerPositionRepository _playerPositionRepository;
        private PlayerRepository _playerRepository;
        private PositionRepository _positionRepository;
        private UserRepository _userRepository;
        #endregion

        #region Properties
        public ArticleRepository ArticleRepository
        {
            get
            {
                if (_articleRepository == null)
                    _articleRepository = new ArticleRepository();
                return _articleRepository;
            }
        }

        public ArticlePhotoRepository ArticlePhotoRepository
        {
            get
            {
                if (_articlePhotoRepository == null)
                    _articlePhotoRepository = new ArticlePhotoRepository();
                return _articlePhotoRepository;
            }
        }

        public NextEventRepository NextEventRepository
        {
            get
            {
                if (_nextEventRepository == null)
                    _nextEventRepository = new NextEventRepository();
                return _nextEventRepository;
            }
        }

        public PhotoRepository PhotoRepository
        {
            get
            {
                if (_photoRepository == null)
                    _photoRepository = new PhotoRepository();
                return _photoRepository;
            }
        }

        public PlayerPhotoRepository PlayerPhotoRepository
        {
            get
            {
                if (_playerPhotoRepository == null)
                    _playerPhotoRepository = new PlayerPhotoRepository();
                return _playerPhotoRepository;
            }
        }

        public PlayerPositionRepository PlayerPositionRepository
        {
            get
            {
                if (_playerPositionRepository == null)
                    _playerPositionRepository = new PlayerPositionRepository();
                return _playerPositionRepository;
            }
        }

        public PlayerRepository PlayerRepository
        {
            get
            {
                if (_playerRepository == null)
                    _playerRepository = new PlayerRepository();
                return _playerRepository;
            }
        }

        public PositionRepository PositionRepository
        {
            get
            {
                if (_positionRepository == null)
                    _positionRepository = new PositionRepository();
                return _positionRepository;
            }
        }

        public UserRepository UserRepository
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
