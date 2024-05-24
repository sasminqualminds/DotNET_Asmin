using Entity.Model;
using Microsoft.EntityFrameworkCore;

namespace Entity.Data
{
    public class PrjContext:DbContext
    {
        public PrjContext(DbContextOptions<PrjContext> contextOptions) : base(contextOptions)
        { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
