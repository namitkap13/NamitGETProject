using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst.Models
{
    [Table("tblImage")]
    public class image
    {
        [Key]
        public int imageId { get; set; }
        public string? imageName { get; set; }
        public int? seriesId { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }

        public virtual series? series { get; set; }
    }
}
