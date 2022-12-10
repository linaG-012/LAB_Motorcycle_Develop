using Contracts;
using Service.Contracts;

namespace Service
{
    internal sealed class CityService : ICityService
    {

        private readonly IRepositoryManager repository;
        private readonly ILoggerManager loggerManager;

        public CityService(IRepositoryManager repository, ILoggerManager loggerManager)
        {
            this.repository = repository;
            this.loggerManager = loggerManager;
        }
    }
}
