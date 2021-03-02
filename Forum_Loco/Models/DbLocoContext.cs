using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Forum_Loco.Models
{
    public class DbLocoContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        // public DbSet<User> Users { get; set; }
        //public DbSet<Order> Orders { get; set; }

        public DbSet<Cart> Carts { get; set; }
    }
}