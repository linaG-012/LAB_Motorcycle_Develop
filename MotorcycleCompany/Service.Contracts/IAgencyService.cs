using Entities.Models;

namespace Service.Contracts

{
    public interface IAgencyService
    {
        IEnumerable<Agency> GetAllAgencies(bool trackChanges);
    }
}
