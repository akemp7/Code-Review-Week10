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
                Vendor showVendor = Vendor.Show(intID);
                return View(showVendor);
            }
        }
        [HttpPost("/vendors/itemDelete")]
        public ActionResult DeleteAll(string vendorsID)
        {
            int intId = int.Parse(vendorsID);
            Vendor.DeleteItem(intId);
            return View();
        }

        // [HttpGet ("/vendors/{id}/orders/new")]
        // public ActionResult Index()
        // {
        //     List<Order> newOrder = Order.GetAll();
        //     return View(newOrder);
        // }

        // [HttpPost("/vendors/{id}/orders/new")]
        // public ActionResult Create(string name, string description, )
        // {
        //     Vendor newVendor = new Vendor(name, description);
        //     return RedirectToAction("Index");
        // }
    }
}