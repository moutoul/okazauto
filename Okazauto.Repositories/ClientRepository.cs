using Okazauto.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okazauto.Repositories
{
    public class ClientRepository : IRepository<ClientPOCO, int>
    {
        private string _connection;
        public ClientRepository(string connection)
        {
            _connection = connection;
        }

  

        public int Add(ClientPOCO clientPOCO)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ClientPOCO Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClientPOCO> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(ClientPOCO obj)
        {
            throw new NotImplementedException();
        }
    }
}
