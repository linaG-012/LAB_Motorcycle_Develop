using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    internal class PhonesRepository : RepositoryBase<Phones>, IPhones
    {
        public PhonesRepository(RepositoryContext context)
      : base(context)
        {

        }
    }
}
