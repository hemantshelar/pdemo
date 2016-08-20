using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UoWFactory
    {
        public static UnitOfWork Get()
        {
            BloggerDbContext dbContext = new BloggerDbContext();
            UnitOfWork uow = new UnitOfWork(dbContext);
            return uow;
        }
    }
}
