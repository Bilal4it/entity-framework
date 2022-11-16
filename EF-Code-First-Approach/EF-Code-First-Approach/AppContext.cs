using Microsoft.EntityFrameworkCore;

namespace EF_Code_First_Approach
{
    public class AppContext : DbContext
    {
        public AppContext()
        { }

        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost;Database=AppDatabase;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
