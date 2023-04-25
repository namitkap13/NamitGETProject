﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EntityCodeFirst.Models
{
    public class user
    {
        public int userId { get; set; }
        public string? userName { get; set; }
        public string? password { get; set; }
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string? gender { get; set; }
        public System.DateTime DOB { get; set; }
        public string? email { get; set; }
        public int roleId { get; set; }
        public virtual role? role { get; set; }
    }
}
