using Microsoft.EntityFrameworkCore;

namespace customerApi.Models
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> TodoItems { get; set; }
    }
}