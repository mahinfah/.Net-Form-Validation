using Microsoft.AspNetCore.Mvc;

namespace labtask.net.Controllers
{
    public class studentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
