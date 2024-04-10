using Employee_CodeFirstApproach.Models.DBEntities;
using Microsoft.EntityFrameworkCore;

namespace Employee_CodeFirstApproach.DAL
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {
        }
        
        public DbSet<Employee> Employees { get; set; }

    }
}
