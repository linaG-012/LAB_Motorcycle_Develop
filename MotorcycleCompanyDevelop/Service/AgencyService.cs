using Contracts;
using Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Contract;
using Entities.Models;

namespace Service
{
    internal sealed class AgencyService : IAgencyService
    {
        private readonly IRepositoryManager repository;
        private readonly IloggerManager loggerManager;

        public AgencyService(IRepositoryManager repository, IloggerManager loggerManager)
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
                loggerManager.LogError($"something went wrong in the[nameof(GetAllAgencies)    servicie method {ex}");
                throw;
            }
        }

        IEnumerable<IAgency> IAgencyService.GetAllAgencies(bool trackchanges)
        {
            throw new NotImplementedException();
        }
    }
}
