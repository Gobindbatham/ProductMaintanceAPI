using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductMaintance.Model;

namespace ProductMaintance.Data
{
    public class ProductMaintanceContext : DbContext
    {
        public ProductMaintanceContext (DbContextOptions<ProductMaintanceContext> options)
            : base(options)
        {
        }

        public DbSet<ProductMaintance.Model.Product> Product { get; set; }

        public DbSet<ProductMaintance.Model.Message> Message { get; set; }
    }
}
