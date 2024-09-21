using GameStore.BLL.DTO.Identity;
using GameStore.WEB.Infrastrcture;
using GameStore.WEB.Models.AccountModels;

namespace GameStore.WEB.Models.UserProfileModels
{
    /// <summary>
    /// view model - Профиль пользователя
    /// </summary>
    public class UserProfileModel
    {
        /// <summary>
        /// Пользователь
        /// </summary>
        public AppUserDTO AppUser { get; set; }

        /// <summary>
        /// Смена пароля
        /// </summary>
        public AccountPasswordModel ChangePassword { get; set; }

        /// <summary>
        /// Результат действий пользователя
        /// </summary>
        public UserActionResult LastAction { get; set; }

        /// <summary>
        /// Вывод ошибки
        /// </summary>
        public NotFoundResultModel NotFound { get; set; }

        //
        public bool IsChangePassword {  get; set; }
    }
}
