using Microsoft.EntityFrameworkCore;

namespace WebApiServer
{
    public class DataContext : DbContext
    {
        public DbSet<DataItem> DataItem { get; set; }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

    }
}