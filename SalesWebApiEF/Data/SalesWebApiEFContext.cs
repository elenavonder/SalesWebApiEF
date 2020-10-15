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

        //have to type in. Not created for us
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Customer>(e =>
            { //when you want to make a unique COLUMN, you need to make a unique INDEX
                e.HasIndex(x => x.Code).IsUnique(); 
            });
        }
    }
}
