using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class NoteDbContextFactory : IDesignTimeDbContextFactory<NoteDbContext>
    {
        public NoteDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<NoteDbContext>();
            optionsBuilder.UseSqlServer("Server=.;Database=Note;Trusted_Connection=True;");

            return new NoteDbContext(optionsBuilder.Options);
        }
    }
}
