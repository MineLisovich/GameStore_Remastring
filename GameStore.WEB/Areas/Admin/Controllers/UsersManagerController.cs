using GameStore.BLL.Infrastrcture.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Policy = IdentityUserPolicy.role_adminOnly)]
    public class UsersManagerController : Controller
    {
        public IActionResult GetUsers()
        {
            return View();
        }
    }
}
