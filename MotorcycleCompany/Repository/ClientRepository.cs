﻿using Contracts;
using Entities.Models;

namespace Repository
{
    public class ClientRepository : RepositoryBase<Client>, IClientRepository
    {
        public ClientRepository(RepositoryContext context) 
            : base(context)
        {
        }
    }
}
