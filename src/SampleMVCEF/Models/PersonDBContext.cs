using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleMVCEF.Models
{
    public class PersonDBContext : DbContext
    {
        public PersonDBContext(DbContextOptions<PersonDBContext> options) : base(options)
        {
        }

        public DbSet<Person> Person { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }

}
