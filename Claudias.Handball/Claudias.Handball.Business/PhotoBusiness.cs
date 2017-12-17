using Claudias.Handball.Business.Core;
using Claudias.Handball.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claudias.Handball.Business
{
    public class PhotoBusiness
    {
        public List<Photo> ReadAll()
        {
            return BusinessContext.Current.RepositoryContext.PhotoRepository.ReadAll();
        }

        public Photo ReadById(Guid photoId)
        {
            return BusinessContext.Current.RepositoryContext.PhotoRepository.ReadById(photoId);
        }

        public void Insert(Photo photo)
        {
            BusinessContext.Current.RepositoryContext.PhotoRepository.Insert(photo);
        }

        public void Update(Photo photo)
        {
            BusinessContext.Current.RepositoryContext.PhotoRepository.Update(photo);
        }

        public void Delete(Guid photoId)
        {
            BusinessContext.Current.RepositoryContext.PhotoRepository.Delete(photoId);
        }
    }
}
