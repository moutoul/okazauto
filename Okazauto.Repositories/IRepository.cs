using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okazauto.Repositories
{
    public interface IRepository<T,U>
        where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Delete(int id);
        void Update(T obj);
        U Add(T obj);
    }
}
