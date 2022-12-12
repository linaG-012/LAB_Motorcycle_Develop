using AutoMapper;
using Contracts;
using Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;

namespace Service
{
    public sealed class ServiceManager : IServiceManager
    {

        private readonly Lazy<IAgencyService> _agencyService;
        private readonly Lazy<ICityService> _cityService;
        private readonly Lazy<IClientService> _clientService;
        private readonly Lazy<IGarageService> _garageService;
        private readonly Lazy<IMotorcycleService> _motorcycleService;
        private readonly Lazy<IPhonesServices> _phonesServices;
        private readonly Lazy<IRentService> _rentService;
       

        public ServiceManager(IRepositoryManager repositoryManager,IloggerManager loggerManager, IMapper mapper)
        {
            _agencyService = new Lazy<IAgencyService>(() => new AgencyService(repositoryManager, loggerManager, mapper));
            _cityService = new Lazy<ICityService>(() => new CityService(repositoryManager, loggerManager, mapper));
            _clientService = new Lazy<IClientService>(() => new ClientService(repositoryManager, loggerManager, mapper));
            _garageService = new Lazy<IGarageService>(() => new GarageService(repositoryManager, loggerManager, mapper));
            _motorcycleService = new Lazy<IMotorcycleService>(() => new MotorcycleService(repositoryManager, loggerManager, mapper));
            _phonesServices = new Lazy<IPhonesServices>(() => new PhonesService(repositoryManager, loggerManager, mapper));
            _rentService = new Lazy<IRentService>(() => new RentService(repositoryManager, loggerManager, mapper));



        }

        public IAgencyService AgencyService => _agencyService.Value;
        public ICityService CityService => _cityService.Value;
        public IClientService ClientService => _clientService.Value;
        public IGarageService GarageService => _garageService.Value;
        public IMotorcycleService MotorcycleService  => _motorcycleService.Value;
        public IPhonesServices PhonesServices => _phonesServices.Value;
        public IRentService RentService => _rentService.Value;
    }
}
