using Microsoft.EntityFrameworkCore; // Needed for DbContext and DbSet

namespace StudentApp
{
    // Manages database and tables
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; } // Represents Students table

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Connect to local SQL Server (LocalDB)
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=StudentDB;Trusted_Connection=True;");
        }
    }
}