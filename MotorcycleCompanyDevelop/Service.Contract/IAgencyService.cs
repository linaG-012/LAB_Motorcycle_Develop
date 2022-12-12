using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using Contracts;
using shared.DataTransferObject;


namespace Service.Contract
{
    public interface IAgencyService
    {
        object GetAgency(Guid id, bool trackChanges);

        //IEnumerable<Agency> GetAllAgencies(bool trackchanges);
        IEnumerable<AgencyDto> GetAllAgencies(bool trackchanges);

    }
}
