using GameStore.BLL.Infrastrcture;
using GameStore.BLL.Predefined;
using GameStore.BLL.Services.UserProfileServices;
using GameStore.WEB.Infrastrcture;
using GameStore.WEB.Models.UserProfileModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Newtonsoft.Json;

namespace GameStore.WEB.Controllers
{
    [Authorize]
    public class UserProfileController : Controller
    {
        private readonly IUserProfileService _userProfileService;
        public UserProfileController(IUserProfileService userProfileService)
        {
            _userProfileService = userProfileService;
        }

        #region PUBLIC METHODS - GET
        [HttpGet]
        public async Task <IActionResult> GetUserProfile()
        {
            UserProfileModel model = await CreateShowUserProfileModel(TempData);
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> GetPartialWorkOnData(string userId, bool isChangePassword)
        {
            UserProfileModel model = await CreateDataUserProfileModel(userId, isChangePassword);
            return PartialView("_Partial.EditUserData", model);
        }
        #endregion

        #region PUBLIC METHODS - POST
        #endregion

        #region PRIVATE METHODS
        private async Task<UserProfileModel> CreateShowUserProfileModel(ITempDataDictionary TempData)
        {
            UserProfileModel model = new();
            model.AppUser = await _userProfileService.GetUserDataByEmailAsync(User.Identity.Name);
            model.LastAction = GetInfoAboutLastActionFromTempData(TempData);
            return model;
        }

        private async Task<UserProfileModel> CreateDataUserProfileModel(string userId, bool isChangePassword)
        {
            UserProfileModel model = new();
            model.AppUser = await _userProfileService.GetUserDataByEmailAsync(userId);
            model.IsChangePassword = isChangePassword;
            return model;

        }
        #endregion

        #region PRIVATE METHODS - TEMP DATA
        private UserActionResult GetInfoAboutLastActionFromTempData(ITempDataDictionary TempData)
        {
            UserActionResult lastAction = (TempData.ContainsKey("LastAction")) ? JsonConvert.DeserializeObject<UserActionResult>((string)TempData["LastAction"]) : new();
            return lastAction;
        }

        //private UserProfileModel GetFromTempData(ITempDataDictionary TempData)
        //{
        //    UserProfileModel model = (TempData.ContainsKey("NotSavedModel")) ? JsonConvert.DeserializeObject<UserProfileModel>((string)TempData["NotSavedModel"]) : null;
        //    return model;
        //}

        private ITempDataDictionary SetTempDataForInfoAboutLastAction(ResultServiceModel result, int actionTypeId)
        {
            PredefinedManager pd = new();
            StandartUserActionTypes actionTypes = new();
            string mainMessage = "";
            if (actionTypeId == actionTypes.Edit.Id)
            {
                mainMessage = (result.IsSucceeded) ? "Данные профиля успешно изменены" : "Не удалось изменить данные профиля";
            }
            else if(actionTypeId == actionTypes.PasswordChange.Id)
            {
                mainMessage = (result.IsSucceeded) ? "Пароль успешно изменён" : "Не удалось изменить пароль";
            }
            else if(actionTypeId == actionTypes.СonfirmEmail.Id)
            {
                mainMessage = (result.IsSucceeded) ? "Email успешно подтверждён" : "Не удалось подтвердить Email";
            }
            else if(actionTypeId == actionTypes.UntieEmail.Id)
            {
                mainMessage = (result.IsSucceeded) ? "Email успешно отвязан" : "Не удалось отвязать Email";
            }
            else if(actionTypeId == actionTypes.Enable2FA.Id)
            {
                mainMessage = (result.IsSucceeded) ? "2FA Включена" : "Не удалось включить 2FA";
            }
            else if( actionTypeId == actionTypes.Disable2FA.Id)
            {
                mainMessage = (result.IsSucceeded) ? "2FA Выключена" : "Не удалось выключить 2FA";
            }

            UserActionResult lastAction = new();
            lastAction.Id = actionTypeId;
            lastAction.IsSuccess = result.IsSucceeded;
            lastAction.DopInfo = mainMessage + ". " + result.ErrorMes;
            TempData["LastAction"] = JsonConvert.SerializeObject(lastAction);
            return TempData;
           
        }
        //private ITempDataDictionary SetTempDataWithUnsavedData(UserProfileModel model)
        //{
        //    TempData["NotSavedModel"] = JsonConvert.SerializeObject(model);
        //    return TempData;
        //}
        #endregion
    }
}
