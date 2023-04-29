using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba9
{
    internal class Teaching
    {
        public int Id { get; set; }
        public ICollection<Disciplines> Disciplines { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
    }
}
