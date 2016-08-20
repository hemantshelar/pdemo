using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    //Generic interface
    public interface IRepository<T>
    {
        void Add(T newEntity);
        void Update(T updatedEntity);
        void Delete(int id);
        T Get(int id);
        List<T> Get(string filter);
    }
}
