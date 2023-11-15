using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace DevSample.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Todo> Todos { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Todo>().ToTable("Todo");
            
            builder.Entity<Todo>()
                .Property(x => x.Title).IsUnicode(false).HasMaxLength(128);


            builder.Entity<Todo>()
                 .Property(x => x.Description).IsUnicode(false).HasMaxLength(1024);
        }


    }
}