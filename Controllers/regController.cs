using labtask.net.Models;
using Microsoft.AspNetCore.Mvc;
namespace labtask.net.Controllers
{
    public class regController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new reg());
        }

        [HttpPost]
        public IActionResult Index(reg obj)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Privacy", "Home");
            }

            return View(obj);
        }
    }
}