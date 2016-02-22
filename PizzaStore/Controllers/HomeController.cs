using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PizzaStore.Models;

namespace PizzaStore.Controllers
{
    public class HomeController : Controller
    {
        private PizzaStoreDbContext context;

        public HomeController()
        {
            context = new PizzaStoreDbContext();
        }

        public ActionResult Index()
        {
            List<Pizza> pizzas = context.Pizzas.ToList();
            return View(pizzas);
        }

        public ActionResult Orders()
        {
            List<Order> orders = context.Orders.ToList();
            return View(orders);
        }

        public ActionResult Details(int id)
        {
            Pizza pizzaDetail = context.Pizzas.Find(id);
            return View(pizzaDetail);
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult _Add(Pizza pizza)
        {
            if (ModelState.IsValid)
            {
                context.Pizzas.Add(pizza);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pizza);
        }

        public ActionResult Edit(int id)
        {
            Pizza pizzaToEdit = context.Pizzas.Find(id);
            return View(pizzaToEdit);
        }

        [HttpPost]
        public ActionResult _Edit(Pizza pizzaToEdit)
        {
            Pizza pizza = context.Pizzas.Find(pizzaToEdit.Id);
            context.Pizzas.Remove(pizza);
            context.Pizzas.Add(pizzaToEdit);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult OrderPizza()
        {

            return View();
        }

        [HttpPost]
        public ActionResult _OrderPizza(Order order)
        {
            if (ModelState.IsValid)
            {
                context.Orders.Add(order);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(order);
        }

        public ActionResult Delete(int id) 
        {
            Pizza pizzaToDelete = context.Pizzas.Find(id);
            context.Pizzas.Remove(pizzaToDelete);
            context.SaveChanges();
            return RedirectToAction("Index"); 
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        
    }
}