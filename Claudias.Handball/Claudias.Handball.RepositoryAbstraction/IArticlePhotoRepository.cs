using Claudias.Handball.Models;

namespace Claudias.Handball.RepositoryAbstraction
{
    public interface IArticlePhotoRepository
    {
        void Insert(ArticlePhoto articlePhoto);
        void Delete(ArticlePhoto articlePhoto);
    }
}
