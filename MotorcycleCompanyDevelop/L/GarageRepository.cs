using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class GarageRepository : RepositoryBase<Garage>, IGarage
    {
        public GarageRepository(RepositoryContext context)
       : base(context)
        {

        }
    }
}
