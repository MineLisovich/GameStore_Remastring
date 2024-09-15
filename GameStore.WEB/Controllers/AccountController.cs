using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.WEB.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }   
        public IActionResult CreateAccount()
        {
            return View();
        }
    }
}
