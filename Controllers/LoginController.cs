using Microsoft.AspNetCore.Mvc;

namespace labtask.net.Controllers
{
    public class LoginController : Controller
    {
       

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Index(string username, string password)
        {

            if (username == "admin" && password == "admin")
            {
                ViewBag.Message = "Login successful";
                
            }
            else
            
                ViewBag.Message = "Invalid username or password";
                return View();
            
        }


    }
}
