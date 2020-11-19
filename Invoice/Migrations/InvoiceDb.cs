using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Invoice.Migrations
{
    public class InvoiceDb : DbContext
    {
        public DbSet<Invoice> Invoice { get; set; }


        public InvoiceDb(DbContextOptions<InvoiceDb> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Invoice>(x =>
            {
                x.Property(c => c.id).IsRequired();
                x.Property(c => c.customerID).IsRequired();
                x.Property(c => c.invoiceDetail).IsRequired();
                x.Property(c => c.date).IsRequired();
            });
        }
    }
}