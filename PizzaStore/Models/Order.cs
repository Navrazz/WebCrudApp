using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStore.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int PizzaId { get; set; }
        public string CustomerName { get; set; }
        public int Quantity { get; set; }
        public virtual Pizza Pizza { get; set; }
    }
}