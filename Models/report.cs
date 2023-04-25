using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst.Models
{
    public class report
    {
        public int reportId { get; set; }
        public string? reportName { get; set; }
        public int seriesId { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }

        public virtual series? series { get; set; }
    }
}
