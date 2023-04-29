using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba9
{
    internal class Speciality
    {
        public int Id { get; set; }
        public int Cypher { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string FormOfStudy { get; set; }
        [Required]
        public string Degree { get; set; }
        public int DurationOfStudy { get; set; }
        public string Depiction { get; set; }
    }
}
