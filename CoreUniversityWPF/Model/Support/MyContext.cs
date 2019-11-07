using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace CoreUniversityWPF.Model.Support
{
    class MyContext:DbContext
    {
        public DbSet<Tables.Student> Students { set; get; }
        public DbSet<Tables.Faculty> Faculties { set; get; }
        public DbSet<Tables.University> Universities { set; get; }

        public MyContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=University");
        }
    }
}
