using Microsoft.EntityFrameworkCore;
using TRexWebApi.Data.Models;

namespace TRexWebApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base()
        {
        }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Map Entity names to DB Table names
            modelBuilder.Entity<Machine>().ToTable("Machine");
        }

        public DbSet<Machine> Machine { get; set; }
    }
}
