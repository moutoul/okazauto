using Okazauto.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okazauto.Repositories
{
    public class FournisseurRepository : IRepository<FournisseurPOCO, int>
    {
        private string _connection;
        public FournisseurRepository(string connection)
        {
            _connection = connection;
        }
        public int Add(FournisseurPOCO obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public FournisseurPOCO Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FournisseurPOCO> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(FournisseurPOCO obj)
        {
            throw new NotImplementedException();
        }
    }
}
