using Microsoft.EntityFrameworkCore;
using PayrollApi.Models;

namespace PayrollApi.Data
{
    public class PayrollContext : DbContext
    {
        public PayrollContext(DbContextOptions<PayrollContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}
