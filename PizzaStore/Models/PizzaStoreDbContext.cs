using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PizzaStore.Models
{
    public class PizzaStoreDbContext : DbContext
    {
        public PizzaStoreDbContext() : base("DefaultConnection")
        {
            Database.SetInitializer<PizzaStoreDbContext>(new PizzaStoreDbInitializer());
        }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}