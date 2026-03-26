using Microsoft.AspNetCore.Mvc;

namespace House_renting_system_Project.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View(); 
        }
    }
}
