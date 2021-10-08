using Microsoft.EntityFrameworkCore;
using los_api.Models;

namespace los_api
{
    public class ProductStockContext : DbContext
    {
        public ProductStockContext(DbContextOptions<ProductStockContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Stock> Stocks { get; set; }
    }
}
