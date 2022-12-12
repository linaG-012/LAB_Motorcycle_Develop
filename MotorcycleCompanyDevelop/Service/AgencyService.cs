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
using AutoMapper;


namespace Service
{
    internal sealed class AgencyService : IAgencyService
    {
        private readonly IRepositoryManager repository;
        private readonly IloggerManager loggerManager;
        private readonly IMapper mapper;

        public AgencyService(IRepositoryManager repository, IloggerManager loggerManager, IMapper mapper)
        {
            this.repository = repository;
            this.loggerManager = loggerManager;
            this.mapper = mapper;
        }

        public IEnumerable<AgencyDto> GetAllAgencies(bool trackchanges)
        {
            try
            {
                var agencies = repository.Agency.GetAllAgencies(trackchanges); //Recibo Models.Agency

                //Transformar el modelo all DTO
                //var agenciesDto = agencies.Select(a => new AgencyDto(a.Addres, a.Neighborhood, a.location, a.Name ?? ""))
                //.ToList();

                var agenciesDto = mapper.Map<IEnumerable<AgencyDto>>(agencies);
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
