using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStore.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public bool IsVegetarian { get; set; }
        public string Image { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}