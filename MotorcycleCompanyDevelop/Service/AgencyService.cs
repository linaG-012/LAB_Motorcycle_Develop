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
using System.Runtime.Serialization;

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


        public AgencyDto GetAgency(Guid agencyId,bool trackchanges)
        {


            var agency = repository.Agency.GetAgency(agencyId, trackchanges);
            if (agency == null)
            {
                throw new AgencyNotFoundExections(agencyId);
            }

            var agencyDto = mapper.Map<AgencyDto>(agency);
            return agencyDto;


        }
        public IEnumerable<AgencyDto> GetAllAgencies(bool trackchanges)
        {
            
            
                var agencies = repository.Agency.GetAllAgencies(trackchanges); //Recibo Models.Agency

                var agenciesDto = mapper.Map<IEnumerable<AgencyDto>>(agencies);
                return agenciesDto; //retornamos el Dto
            
            
        }

        object IAgencyService.GetAgency(Guid id, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }

    [Serializable]
    internal class AgencyNotFoundExections : Exception
    {
        private Guid agencyId;

        public AgencyNotFoundExections()
        {
        }

        public AgencyNotFoundExections(Guid agencyId)
        {
            this.agencyId = agencyId;
        }

        public AgencyNotFoundExections(string? message) : base(message)
        {
        }

        public AgencyNotFoundExections(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected AgencyNotFoundExections(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
