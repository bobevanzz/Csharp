using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace StudentTable
{
    public class Student
    {   
        [Required]
        public int Id {get;set;}
        [MaxLength(30)]
        [Required]
        public string Name { get; set; }
        [MaxLength(30)]
        [Required]
        public string Major { get; set; }
        [MaxLength(30)]
        [Required]
        public string College { get; set; }
        [Required]
        public int GradYear { get; set; }
        [Required]
        public bool GradWithHonors { get; set; }
        public bool AlumniDonor { get; set; }
    }
}
