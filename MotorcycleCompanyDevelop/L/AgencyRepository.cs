using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class AgencyRepository : RepositoryBase<Agency>, IAgency
    {
        public AgencyRepository(RepositoryContext context)
        : base(context)
        {

        }

        public IEnumerable<Agency> GetAllAgencies(bool trackchanges) =>
            FindAll(trackchanges).Include("phones")
            .OrderBy(a => a.name)
            .ToList();
        //implementation
    }
}
