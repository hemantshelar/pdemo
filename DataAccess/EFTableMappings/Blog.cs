using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EFTableMappings
{
    [Table("Blog")]
    public class Blog
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public DateTime PublishDate { get; set; }

        [Column("Dislikes")]
        public int DislikeCount { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }

        public virtual UserInfo UserInfo { get; set; }
        
    }
}
