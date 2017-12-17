using Claudias.Handball.RepositoryAbstraction.Core;
using Claudias.Handball.RepositoryFactory;
using System;

namespace Claudias.Handball.Business.Core
{
    public class BusinessContext : IDisposable
    {
        #region Members
        private static BusinessContext _instance;

        private IRepositoryContext _repositoryContext;

        private ArticleBusiness _articleBusiness;
        private ArticlePhotoBusiness _articlePhotoBusiness;
        private NextEventBusiness _nextEventBusiness;
        private PhotoBusiness _photoBusiness;
        private PlayerPhotoBusiness _playerPhotoBusiness;
        private PlayerPositionBusiness _playerPositionBusiness;
        private PlayerBusiness _playerBusiness;
        private PositionBusiness _positionBusiness;
        private UserBusiness _userBusiness;
        #endregion

        #region Constructor
        public BusinessContext()
        {
            _instance = this;
            _repositoryContext = Getter.GetRepository();
        }
        #endregion

        #region Properties
        internal static BusinessContext Current
        {
            get
            {
                if (_instance == null)
                {
                    throw new Exception("No BusinessContext instance available!");
                }
                return _instance;
            }
        }

        public ArticleBusiness ArticleBusiness
        {
            get
            {
                if (_articleBusiness == null)
                    _articleBusiness = new ArticleBusiness();
                return _articleBusiness;
            }
        }

        public ArticlePhotoBusiness ArticlePhotoBusiness
        {
            get
            {
                if (_articlePhotoBusiness == null)
                    _articlePhotoBusiness = new ArticlePhotoBusiness();
                return _articlePhotoBusiness;
            }
        }

        public NextEventBusiness NextEventBusiness
        {
            get
            {
                if (_nextEventBusiness == null)
                    _nextEventBusiness = new NextEventBusiness();
                return _nextEventBusiness;
            }
        }

        public PhotoBusiness PhotoBusiness
        {
            get
            {
                if (_photoBusiness == null)
                    _photoBusiness = new PhotoBusiness();
                return _photoBusiness;
            }
        }

        public PlayerPhotoBusiness PlayerPhotoBusiness
        {
            get
            {
                if (_playerPhotoBusiness == null)
                    _playerPhotoBusiness = new PlayerPhotoBusiness();
                return _playerPhotoBusiness;
            }
        }

        public PlayerPositionBusiness PlayerPositionBusiness
        {
            get
            {
                if (_playerPositionBusiness == null)
                    _playerPositionBusiness = new PlayerPositionBusiness();
                return _playerPositionBusiness;
            }
        }

        public PlayerBusiness PlayerBusiness
        {
            get
            {
                if (_playerBusiness == null)
                    _playerBusiness = new PlayerBusiness();
                return _playerBusiness;
            }
        }

        public PositionBusiness PositionBusiness
        {
            get
            {
                if (_positionBusiness == null)
                    _positionBusiness = new PositionBusiness();
                return _positionBusiness;
            }
        }

        public UserBusiness UserBusiness
        {
            get
            {
                if (_userBusiness == null)
                    _userBusiness = new UserBusiness();
                return _userBusiness;
            }
        }
        internal IRepositoryContext RepositoryContext
        {
            get { return _repositoryContext; }
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
                if (_articleBusiness != null)
                {

                    _articleBusiness = null;
                }

                if (_articlePhotoBusiness != null)
                {

                    _articlePhotoBusiness = null;
                }

                if (_nextEventBusiness != null)
                {
                    _nextEventBusiness = null;
                }

                if (_photoBusiness != null)
                {
                    _photoBusiness = null;
                }

                if (_playerPhotoBusiness != null)
                {
                    _playerPhotoBusiness = null;
                }

                if (_playerPositionBusiness != null)
                {
                    _playerPositionBusiness = null;
                }

                if (_playerBusiness != null)
                {
                    _playerBusiness = null;
                }

                if (_positionBusiness != null)
                {
                    _positionBusiness = null;
                }

                if (_userBusiness != null)
                {
                    _userBusiness = null;
                }
                if (_repositoryContext != null)
                {
                    _repositoryContext.Dispose();
                    _repositoryContext = null;
                }

                if (_instance != null)
                {
                    _instance = null;
                }
            }
        }

        ~BusinessContext()
        {
            Dispose(false);
        }
    #endregion
    }
}


