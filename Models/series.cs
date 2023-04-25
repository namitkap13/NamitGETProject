using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst.Models
{
    public class series
    {
        public int seriesId { get; set; }
        public string? seriesName { get; set; }
        public int studyId { get; set; }
        public virtual study? study { get; set; }
        public virtual ICollection<image>? images { get; set; }
        public virtual ICollection<report>? reports { get; set; }
        public virtual ICollection<video>? videos { get; set; }
    }
}
