using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    internal abstract class NotFoundExceptions : Exception
    {
        protected NotFoundExceptions(string message, object agencyId)
            :base($"The Agency With id: {agencyId} doesn't exist in the database")
        {
        }
    }
}
