using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;
        private readonly Lazy<IAgency> _agency;
        private readonly Lazy<IClient> _client;

        public RepositoryManager(RepositoryContext context)
        {
            _context = context;
            _agency = new Lazy<IAgency>(() => new AgencyRepository(context));
            //_client = new Lazy<IClient>(() => new ClientRepository(context));
        }

        public IAgency Agency => _agency.Value;
        //public IClient Client => _client.Value;
        public void Save() => _context.SaveChanges();

    }
}
