using Contracts;
using Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal sealed class ClientService : IClientService
    {
        private readonly IRepositoryManager repository;
        private readonly IloggerManager loggerManager;

        public ClientService(IRepositoryManager repository, IloggerManager loggerManager, AutoMapper.IMapper mapper)
        {
            this.repository = repository;
            this.loggerManager = loggerManager;
        }
    }
}
