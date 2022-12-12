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
       
        //IEnumerable<Agency> GetAllAgencies(bool trackchanges);
        IEnumerable<AgencyDto> GetAllAgencies(bool trackchanges);

    }
}
