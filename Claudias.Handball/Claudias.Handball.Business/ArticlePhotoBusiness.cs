using Claudias.Handball.Business.Core;
using Claudias.Handball.Models;

namespace Claudias.Handball.Business
{
    public class ArticlePhotoBusiness
    {
        public void Insert(ArticlePhoto articlePhoto)
        {
            BusinessContext.Current.RepositoryContext.ArticlePhotoRepository.Insert(articlePhoto);
        }

        public void Delete(ArticlePhoto articlePhoto)
        {
            BusinessContext.Current.RepositoryContext.ArticlePhotoRepository.Delete(articlePhoto);
        }
    }
}
