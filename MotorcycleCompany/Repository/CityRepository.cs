using Contracts;
using Entities.Models;

namespace Repository
{
    public class CityRepository : RepositoryBase<City>, ICityRepository
    {
        public CityRepository(RepositoryContext context) 
            : base(context)
        {
        }
    }
}
