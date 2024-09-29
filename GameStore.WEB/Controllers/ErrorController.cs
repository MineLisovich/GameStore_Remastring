using Microsoft.AspNetCore.Mvc;

namespace GameStore.WEB.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult NotFoundPage() => View();
        public IActionResult ForbiddenResource() => View();
    }
}
