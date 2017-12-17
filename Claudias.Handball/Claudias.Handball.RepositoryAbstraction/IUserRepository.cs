using Claudias.Handball.Models;
using System;
using System.Collections.Generic;

namespace Claudias.Handball.RepositoryAbstraction
{
    public interface IUserRepository
    {
        List<User> ReadAll();
        User ReadById(Guid userId);
        void Insert(User user);
        void Update(User user);
        void Delete(Guid userId);
    }
}
