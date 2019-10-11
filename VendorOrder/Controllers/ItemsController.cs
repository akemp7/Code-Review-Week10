using Microsoft.AspNetCore.Mvc;
using Tracking.Models;
using System.Collections.Generic;

namespace Tracking.Controllers
{
    public class ItemsController : Controller
    {
        [HttpGet("/vendors")]
        public ActionResult Index()
        {
            List<Vendor> newVendor = Vendor.GetAll();
            return View(newVendor);
        }

     

        [HttpGet("/vendors/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/vendors")]
        public ActionResult Create(string vendorName, string description)
        {
            Vendor newVendor = new Vendor(vendorName, description);
            return RedirectToAction("Index");
        }

        [HttpGet("/vendors/{id}")]
        public ActionResult Show(string vendorsID)
        {

            List<Vendor> newVendor = Vendor.GetAll();
            if (newVendor.Count == 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                int intID = int.Parse(vendorsID);
                Vendor showVendor = Vendor.Find(intID);
                Dictionary<string, object> model = new Dictionary<string, object>();
                List<Order> orderItems = showVendor.Orders;
                model.Add("category", showVendor);
                model.Add("items", orderItems);
                return View(model);
            }
        }
    }
}

// int ID = int.Parse(id);
// Vendor selectVendor = Vendor.Find(ID);
// Dictionary<string, object> model = new Dictionary<string, object>();
// List<Order> orderItems = selectVendor.Orders;
// model.Add("vendor", selectVendor);
//             model.Add("orders", orderItems);
//             return View(model);