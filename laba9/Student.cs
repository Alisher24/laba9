using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba9
{
    internal class Student
    {
        [Key]
        public int NumberOfBook { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Name { get; set; }
        public string Surname { get; set; }
        public ICollection<Group> Groups { get; set; }
        [Range(1900, 2100, ErrorMessage = "Please enter a valid year")]
        [Required]
        public DateTime YearOfAdmission { get; set; }
    }
}
