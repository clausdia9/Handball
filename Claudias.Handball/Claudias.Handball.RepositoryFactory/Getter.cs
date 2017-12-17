using Claudias.Handball.Repository.Core;
using Claudias.Handball.RepositoryAbstraction.Core;
using System.Configuration;

namespace Claudias.Handball.RepositoryFactory
{
    public class Getter
    {
        public static IRepositoryContext GetRepository()
        {
            string type = ConfigurationManager.AppSettings["RequestedType"];
            if (type.Equals("ADO"))
                return new RepositoryContext();

            return default(IRepositoryContext);
        }
    }
}
