using Microsoft.EntityFrameworkCore;
using EmployeeManagerMVC.Models;

namespace EmployeeManagerMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

        public DbSet<Employee> Employees { get; set; }
    }
}
