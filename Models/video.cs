using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst.Models
{
    public class video
    {
        public int videoId { get; set; }
        public string? videoName { get; set; }
        public int seriesId { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
        public virtual series? series { get; set; }
    }
}
