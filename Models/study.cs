using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst.Models
{
    
    public class study
    {
        public int studyId { get; set; }
        public string? studyName { get; set; }
        public int patientId { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }

        public virtual patient? patient { get; set; }

        public virtual ICollection<series>? series { get; set; }
    }
}
