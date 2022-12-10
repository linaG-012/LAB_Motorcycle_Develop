using Entities.Models;

namespace Contracts
{
    public interface IAgencyRepository
    {
        IEnumerable<Agency> GetAllAgencies(bool trackChanges);
    }
}
