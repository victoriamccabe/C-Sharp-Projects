using Microsoft.EntityFrameworkCore;

namespace CarInsurance.Models
{
    public class InsuranceContext : DbContext
    {
        public InsuranceContext(DbContextOptions<InsuranceContext> options)
            : base(options)
        {
        }

        // Table for Insurees
        public DbSet<Insuree> Insurees { get; set; }
    }
}
