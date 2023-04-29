using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba9
{
    internal class Disciplines
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<Speciality> Specialities { get; set; }
        public int Semester { get; set; }
        public int AllOfTima { get; set; }
        [Required]
        public string Reporting { get; set; }
    }
}
