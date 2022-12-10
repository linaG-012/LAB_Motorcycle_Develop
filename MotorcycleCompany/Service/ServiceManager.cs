using Contracts;
using Service.Contracts;

namespace Service
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IAgencyService> _agencyService;

        private readonly Lazy<ICityService> _cityService;

        private readonly Lazy<IClientService> _clientService;


        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager loggerManager)
        {
            _agencyService = new Lazy<IAgencyService>(()=> new AgencyService(repositoryManager, loggerManager));
            _clientService = new Lazy<IClientService>(() => new ClientService(repositoryManager, loggerManager));
             _cityService = new Lazy<ICityService>(() => new CityService(repositoryManager, loggerManager));
        }

        public IAgencyService AgencyService => _agencyService.Value;

        public ICityService CityService => _cityService.Value;

        public IClientService ClientService => _clientService.Value;
    }
}
