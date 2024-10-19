using GameStore.BLL.Infrastrcture.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Policy = IdentityUserPolicy.role_adminOnly)]
    public class DictionariesController : Controller
    {
        #region PUBLIC METHODS - GET
        public IActionResult Index()
        {
            return View();
        }
        #endregion

        #region PUBLIC METHODS - POST
        #endregion

        #region PRIVATE METHODS 
        #endregion

        #region PRIVATE METHODS  - TEMPDATA
        #endregion

    }
}
