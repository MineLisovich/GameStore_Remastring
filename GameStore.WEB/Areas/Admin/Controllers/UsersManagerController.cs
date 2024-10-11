using GameStore.BLL.Infrastrcture;
using GameStore.BLL.Infrastrcture.Identity;
using GameStore.BLL.Predefined;
using GameStore.BLL.Services.UserManagerServices;
using GameStore.WEB.Areas.Admin.Models.UserManagerModels;
using GameStore.WEB.Infrastrcture;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Newtonsoft.Json;

namespace GameStore.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Policy = IdentityUserPolicy.role_adminOnly)]
    public class UsersManagerController : Controller
    {
        private readonly IUserManagerService _userManagerService;
        public UsersManagerController(IUserManagerService userManagerService)
        {
            _userManagerService = userManagerService;
        }

        #region PUBLIC METHODS - GET
        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            ShowUserManagerModel model = await CreateShowModel(TempData);
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> GetPartialWorkOnData(string userId)
        {
            DataUserManagerModel model = await CreateDataModel(userId);
            return PartialView("_Partial.GetUsers.CreateEditForm", model);
        }

        [HttpGet]
        public async Task <IActionResult> DeleteUserAccount(string userId)
        {
            ResultServiceModel result = await _userManagerService.DeleteUserAsync(User.Identity.Name, userId);
            StandartUserActionTypes actionTypes = new();
            TempData = SetTempDataForInfoAboutLastAction(result, actionTypes.Delete.Id);
            return Json(result);

        }
        #endregion
        #region PUBLIC METHODS - POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateUser(DataUserManagerModel model)
        {
            ResultServiceModel result = await _userManagerService.GreateUserAsync(model.AppUser);
            StandartUserActionTypes actionTypes = new();
            TempData = SetTempDataForInfoAboutLastAction(result, actionTypes.Create.Id);
            return RedirectToAction(nameof(GetUsers));
        }      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditUser(DataUserManagerModel model)
        {
            ResultServiceModel result = await _userManagerService.UpdateUserAsync(User.Identity.Name,model.AppUser);
            StandartUserActionTypes actionTypes = new();
            TempData = SetTempDataForInfoAboutLastAction(result, actionTypes.Edit.Id);
            return RedirectToAction(nameof(GetUsers));
        }
        #endregion
        #region PRIVATE METHODS 
        private async Task<ShowUserManagerModel> CreateShowModel(ITempDataDictionary TempData)
        {
            ShowUserManagerModel model = new();
            model.AppUsers = await _userManagerService.GetAllAppUserAsync();
            model.LastAction = new();
            model.LastAction = GetInfoAboutLastActionFromTempData(TempData);
            return model;
        }

        public async Task<DataUserManagerModel> CreateDataModel(string userId)
        {
            DataUserManagerModel model = new();
            PredefinedManager pd = new();
            //Create mode
            if (userId is null)
            {
                model.AppUser = new();            
            }
            //Edit mode
            else
            {
                model.AppUser = await _userManagerService.GetAppUserByEmailAsync(userId);
            }

            model.SelectListItems_Roles = new SelectList(pd.AppRole.RoleList, "Name", "Name");

           return model;
        }
        #endregion      

        #region PRIVATE METHODS - TEMPDATA
        private UserActionResult GetInfoAboutLastActionFromTempData(ITempDataDictionary TempData)
        {
            UserActionResult lastAction = (TempData.ContainsKey("LastAction")) ? JsonConvert.DeserializeObject<UserActionResult>((string)TempData["LastAction"]) : new();
            return lastAction;
        }
        private ITempDataDictionary SetTempDataForInfoAboutLastAction(ResultServiceModel result, int actionTypeId)
        {
            StandartUserActionTypes actionTypes = new();
            string mainMessage = "";
            if (actionTypeId == actionTypes.Create.Id)
            {
                mainMessage = (result.IsSucceeded) ? "Пользователь создан" : "Не удалось создать пользователя";
            }
            else if (actionTypeId == actionTypes.Edit.Id)
            {
                mainMessage = (result.IsSucceeded) ? "Данные пользователя успешно изменены" : $"Не удалось изменить данные пользователя";
            }

            else if (actionTypeId == actionTypes.Delete.Id)
            {
                mainMessage = (result.IsSucceeded) ? "Пользователь успешно удалён" : $"Не удалось удалить пользователя";
            }

            UserActionResult lastAction = new();
            lastAction.Id = actionTypeId;
            lastAction.IsSuccess = result.IsSucceeded;
            lastAction.DopInfo = mainMessage + ". " + result.ErrorMes;
            TempData["LastAction"] = JsonConvert.SerializeObject(lastAction);
            return TempData;

        }
        #endregion
    }
}
