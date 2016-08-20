using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class RepositoryImpl<T> : IRepository<T> where T : class
    {
        BloggerDbContext _context = new BloggerDbContext();

        public RepositoryImpl(BloggerDbContext _context)
        {
            this._context = _context;
        }

        public void Add(T newEntity)
        {
            _context.Set<T>().Add(newEntity);
            _context.SaveChanges();
            //int nCount = _context.SaveChanges();
            //Console.WriteLine(nCount);
        }

        public void Update(T updatedEntity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            var entityToDelete = Get(id);
            _context.Set<T>().Remove(entityToDelete);
            int n = _context.SaveChanges();
            
        }

        public T Get(int id)
        {
            var context = _context.Set<T>();
            var result = context.Find(id);
            return result;
        }


        public List<T> Get(string filter)
        {
            throw new NotImplementedException();
        }
    }
}
