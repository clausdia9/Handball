using Claudias.Handball.Models;
using System;
using System.Collections.Generic;

namespace Claudias.Handball.RepositoryAbstraction
{
    public interface IPhotoRepository
    {
        List<Photo> ReadAll();
        Photo ReadById(Guid photoId);
        void Insert(Photo photo);
        void Update(Photo photo);
        void Delete(Guid photoId);
    }
}
