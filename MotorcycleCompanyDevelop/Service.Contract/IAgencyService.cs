using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using Contracts;

namespace Service.Contract
{
    public interface IAgencyService
    {
        IEnumerable<IAgency> GetAllAgencies(bool trackchanges);
    }
}
