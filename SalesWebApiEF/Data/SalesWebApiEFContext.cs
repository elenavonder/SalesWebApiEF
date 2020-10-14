using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebApiEF.Models;

namespace SalesWebApiEF.Data
{
    public class SalesWebApiEFContext : DbContext
    {
        public SalesWebApiEFContext (DbContextOptions<SalesWebApiEFContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWebApiEF.Models.Customer> Customer { get; set; }

        public DbSet<SalesWebApiEF.Models.Order> Order { get; set; }

        public DbSet<SalesWebApiEF.Models.OrderLine> OrderLine { get; set; }

        public DbSet<SalesWebApiEF.Models.Product> Product { get; set; }
    }
}
