using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EFTableMappings
{
    [Table("UserInfo")]
    public class UserInfo
    {        
        [Column("Id")]
        public int Id { get; set; }

        [Column("UserName")]
        public string Name { get; set; }

        [Column("City")]
        public string HomeCity { get; set; }

        public virtual List<Blog> Blogs { get; set; }
        //http://www.entityframeworktutorial.net/code-first/configure-one-to-many-relationship-in-code-first.aspx
    }
}
