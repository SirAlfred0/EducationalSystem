using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace persistence
{
    public class RepositoryDbContext : DbContext
    {

        public RepositoryDbContext(DbContextOptions<RepositoryDbContext> options)
             : base(options)
        {
        }

        public DbSet<Class> Classes { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<ClassesStudents> ClassesStudents { get; set; }

        public DbSet<CreatedClass> CreatedClasses { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder) =>
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(RepositoryDbContext).Assembly);
    }
}
