using Contracts;
using Service.Contracts;

namespace Service
{
    internal sealed class ClientService : IClientService
    {

        private readonly IRepositoryManager repository;
        private readonly ILoggerManager loggerManager;

        public ClientService(IRepositoryManager repository, ILoggerManager loggerManager)
        {
            this.repository = repository;
            this.loggerManager = loggerManager;
        }
    }
}
