using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba9
{
    internal class Studying
    {
        public ICollection<Student> Students { get; set; }
        public ICollection<Disciplines> Disciplines { get; set; }
        [Key]
        public DateTime DeliveryDate { get; set; }
        public int Grade { get; set; }
    }
}
