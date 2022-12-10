using Contracts;
using Service.Contracts;
using Entities.Models;



namespace Service
{
    internal sealed class AgencyService : IAgencyService
    {

        private readonly IRepositoryManager repository;
        private readonly ILoggerManager loggerManager;

        public AgencyService(IRepositoryManager repository, 
            ILoggerManager loggerManager)
        {
            this.repository = repository;
            this.loggerManager = loggerManager;
        }
        
      
        public IEnumerable<Agency> GetAllAgencies(bool trackchanges)
        {
            try
            {
                var agencies = repository.Agency.GetAllAgencies(trackchanges);
                return agencies;
            }
            catch (Exception ex)
            {
                loggerManager.LogError($"Sonetring went in the {nameof(GetAllAgencies)} service method { ex}");
                    throw;
            }
        }
    }
}
