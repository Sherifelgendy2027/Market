using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Amazon.Models;

    public class AmazonContext : DbContext
    {
        public AmazonContext (DbContextOptions<AmazonContext> options)
            : base(options)
        {
        }

        public DbSet<Amazon.Models.Product> Product { get; set; } = default!;

        public DbSet<Amazon.Models.Category> Category { get; set; } = default!;
    }
