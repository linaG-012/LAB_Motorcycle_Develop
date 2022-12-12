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

        public IEnumerable<AgencyDto> GetAllAgencies(bool trackchanges)
        {
            var agencies = repository.Agency.GetAllAgencies(trackchanges);

            var ageenciesdto = mapper.Map<IEnumerable<AgencyDto>>(agencies);
            return ageenciesdto;
        }
    }
}
