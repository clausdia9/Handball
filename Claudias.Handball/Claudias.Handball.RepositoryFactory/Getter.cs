using Claudias.Handball.Repository.Core;
using Claudias.Handball.RepositoryAbstraction.Core;

namespace Claudias.Handball.RepositoryFactory
{
    public class Getter
    {
        public static IRepositoryContext GetRepository()
        {
            //Get data from config.
            bool isADONetRepositoryRequested = true;
            if (isADONetRepositoryRequested)
               return new RepositoryContext();

            return default(IRepositoryContext);
        }
    }
}
