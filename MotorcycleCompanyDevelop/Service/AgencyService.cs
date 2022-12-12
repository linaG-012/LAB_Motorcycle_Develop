using Contracts;
using Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Contract;
using Entities.Models;
using shared.DataTransferObject;
using Microsoft.VisualBasic;
using System.Xml.Linq;


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

        public IEnumerable<AgencyDto> GetAllAgencies(bool trackchanges)
        {
            try
            {
                var agencies = repository.Agency.GetAllAgencies(trackchanges); //Recibo Models.Agency

                //Transformar el modelo all DTO
                var agenciesDto = agencies.Select(a => new AgencyDto(a.Addres, a.Neighborhood, a.location, a.Name ?? ""))
                .ToList();

                return agenciesDto; //retornamos el Dto
            }
            catch (Exception ex)
            {
                loggerManager.LogError($"something went wrong in the[nameof(GetAllAgencies)    servicie method {ex}");
                throw;
            }
        }

        
    }
}
