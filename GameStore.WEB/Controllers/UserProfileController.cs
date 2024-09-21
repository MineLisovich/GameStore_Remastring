using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.WEB.Controllers
{
    [Authorize]
    public class UserProfileController : Controller
    {
        #region PUBLIC METHODS - GET
        public IActionResult GetUserProfile()
        {
            return View();
        }
        #endregion

        #region PUBLIC METHODS - POST
        #endregion

        #region PRIVATE METHODS
        #endregion

        #region PRIVATE METHODS - TEMP DATA
        #endregion
    }
}
