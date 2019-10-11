using Microsoft.AspNetCore.Mvc;
using Tracking.Models;

namespace Tracking.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }

    }
}