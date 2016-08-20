using DataAccess.EFTableMappings;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BloggerDbContext : DbContext
    {
        public DbSet<UserInfo> UserInfo { get; set; }

        public BloggerDbContext(string connectionStringName)
            : base(connectionStringName)
        {
            Console.WriteLine("Invoking constructor with one argument.  Connection string is : "  + connectionStringName);
        }
        public BloggerDbContext()
            : this("BloggingContext")
        {
            Console.WriteLine("Invoking constructor with no arguments.");
        }
    }
}
