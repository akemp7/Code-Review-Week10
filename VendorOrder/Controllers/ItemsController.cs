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

        [HttpPost("/vendors")]
        public ActionResult Create(string name, string description)
        {
            Vendor newVendor = new Vendor(name, description);
            return RedirectToAction("Index");
        }

        [HttpGet("/vendors/new")]
        public ActionResult New()
        {
            return View();
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
        public ActionResult Delete(string searchID)
        {
            int intId = int.Parse(searchID);
            Vendor.DeleteItem(intId);
            return View();
        }

    }
}