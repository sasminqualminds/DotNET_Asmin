using EntityFramework.Model;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Controllers.Data
{
    public class PrjContext:DbContext
    {
        public PrjContext(DbContextOptions<PrjContext> contextOptions) : base(contextOptions)
        { }

       public DbSet<Employees> Employees { get; set; }
        public DbSet<Customers> Customers { get; set; }
       
        
    }
}
