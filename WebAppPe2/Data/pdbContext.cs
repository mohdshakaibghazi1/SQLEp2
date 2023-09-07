using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppPe2.Models;

namespace WebAppPe2.Data
{
    public class pdbContext : DbContext
    {
        public pdbContext (DbContextOptions<pdbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppPe2.Models.Order> Order { get; set; } = default!;

        public DbSet<WebAppPe2.Models.OrderDetail>? OrderDetail { get; set; }

        public DbSet<WebAppPe2.Models.Product>? Product { get; set; }
    }
}
