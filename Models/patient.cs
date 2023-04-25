using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst.Models
{
    [Table("tblpatient")]
    public class patient
    {
        [Key]
        public int patientId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public System.DateTime DOB { get; set; }
        public string gender { get; set; }
    }
}
