using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PizzaStore.Models
{
    public class PizzaStoreDbInitializer : CreateDatabaseIfNotExists<PizzaStoreDbContext>
    {
        protected override void Seed(PizzaStoreDbContext context)
        {
            Pizza margeritaPizza = new Pizza() { Name = "Margerita", Price = 10f, IsVegetarian = true, Image = "http://www.peperonipizza.pl/files/pizza-margerita.jpg" };
            Pizza jalapenoPizza = new Pizza() { Name = "Jalapeno", Price = 20f, IsVegetarian = false, Image = "http://farm9.staticflickr.com/8055/8113851206_12953cde35_b.jpg" };
            Pizza hawaiPizza = new Pizza() { Name = "Hawajska", Price = 18f, IsVegetarian = false, Image = "http://www.peperonipizza.pl/files/pizza-hawajska.jpg" };

            List<Pizza> pizzas = new List<Pizza>();
            pizzas.Add(margeritaPizza);
            pizzas.Add(jalapenoPizza);
            pizzas.Add(hawaiPizza);

            context.Pizzas.AddRange(pizzas);
            context.SaveChanges();

            base.Seed(context);
        }
    }
}