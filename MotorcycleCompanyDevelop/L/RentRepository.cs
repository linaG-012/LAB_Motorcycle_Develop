using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    internal class RentRepository: RepositoryBase<Rent>, IRent
    {
        public RentRepository(RepositoryContext context)
      : base(context)
        {

        }
    }
}
