using Claudias.Handball.Business.Core;
using Claudias.Handball.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claudias.Handball.Business
{
    public class UserBusiness
    {
        public List<User> ReadAll()
        {
            return BusinessContext.Current.RepositoryContext.UserRepository.ReadAll();
        }

        public User ReadById(Guid userId)
        {
            return BusinessContext.Current.RepositoryContext.UserRepository.ReadById(userId);
        }

        public void Insert(User user)
        {
            BusinessContext.Current.RepositoryContext.UserRepository.Insert(user);
        }

        public void Update(User user)
        {
            BusinessContext.Current.RepositoryContext.UserRepository.Update(user);
        }

        public void Delete(Guid userId)
        {
            BusinessContext.Current.RepositoryContext.UserRepository.Delete(userId);
        }
    }
}
