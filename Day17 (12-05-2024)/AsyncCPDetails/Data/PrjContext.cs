﻿using AsyncCPDetails.Model;
using Microsoft.EntityFrameworkCore;

namespace AsyncCPDetails.Data
{
    public class PrjContext:DbContext
    {
        public PrjContext(DbContextOptions<PrjContext> contextOptions) : base(contextOptions)
        { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<Purchase> Purchases { get; set;}

    }
}
