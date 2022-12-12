﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using shared.DataTransferObject;


namespace Contracts
{
    public interface IAgency
    {
        //IEnumerable<Agency> GetAllAgencies(bool trackchanges);
        IEnumerable<AgencyDto> GetAllAgencies(bool trackChanges);
        Agency GetAgency(Guid agencyId, bool trackChanges);
    }
}
