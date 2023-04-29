using laba9;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

var optionsBuilder = new DbContextOptionsBuilder<Decanat>();
optionsBuilder.UseSqlServer("Data Source=LEGION-5-PRO\\SQLEXPRESS;Initial Catalog=Decanat;Integrated Security=True;Encrypt=False;");

using (var context = new Decanat(optionsBuilder.Options))
{
    context.Database.EnsureDeleted();
    context.Database.EnsureCreated();
}