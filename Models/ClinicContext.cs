using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityCodeFirst.Models
{
    public class ClinicContext : DbContext
    {
        public ClinicContext() 
            :base("name=ClinicDB")
        { }
        public DbSet<role>? Roles { get; set; }
        public DbSet<user>? Users { get; set; }
        public DbSet<image>? Images { get; set; }
        public DbSet<report>? Reports { get; set; }
        public DbSet<patient>? Patients { get; set; }
        public DbSet<study>? Studies { get; set; }
        public DbSet<video>? Videos { get; set; }
        public DbSet<series>? Series { get; set; }




    }


}
