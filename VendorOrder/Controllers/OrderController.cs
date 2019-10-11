using Microsoft.AspNetCore.Mvc;
using Tracking.Models;
using System.Collections.Generic;

namespace Tracking.Controllers
{
    public class OrderController : Controller
    {

        [HttpGet("/orders")]
        public ActionResult Index()
        {
            List<Order> orders = Order.GetAll();
            return View(orders);
        } 

        [HttpGet("/orders/new")]
        public ActionResult New()
        {
            return View();
        }

 
        [HttpPost ("/orders")]
        public ActionResult Create(string order, string description, string price)
        {
            Order orders = new Order(order, description, price);
            return RedirectToAction("Index");
        }

        [HttpGet("/orders/{id}")]
        public ActionResult Show(string id)
        {
            int intID = int.Parse(id);
            Vendor showVendor = Vendor.Find(intID);
            Dictionary<string, object> model = new Dictionary<string, object>();
            List<Order> orderItems = showVendor.Orders;
            model.Add("category", showVendor);
            model.Add("items", orderItems);
            return View(model);
        }
    }
}