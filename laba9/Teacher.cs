using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba9
{
    internal class Teacher
    {
        [Key]
        public int PersonnelNumber { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Name { get; set; }
        public string Surname { get; set; }
        [Required]
        public string AcademicDegree { get; set; }
        [Required]
        public string AcademicTitle { get; set; }
        [Required]
        public string Department { get; set; }
    }
}
