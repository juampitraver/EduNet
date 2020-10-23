using Microsoft.EntityFrameworkCore;
using TP3.Domain.Entities;

namespace TP3.Infrastructure
{
    public class Context : DbContext
    {

        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();
        }

        #region DbSet
        public DbSet<Challenge> Challenge { get; set; }
        public DbSet<User> User { get; set; }


        #endregion
    }
}
