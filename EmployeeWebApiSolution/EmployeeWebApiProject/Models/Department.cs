﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeWebApiProject.Models
{
    public class Department
    {
        public int Id { get; set; }
        [StringLength(80)]
        public string Name { get; set; }
        public int EmployeeId { get; set; }
        public decimal Budget { get; set; }

    }
}