using System.ComponentModel.DataAnnotations;

namespace GameStore.WEB.Models.AccountModels
{
    /// <summary>
    /// Модель для восстановления пароля или смены пароля
    /// </summary>
    public class AccountPasswordModel
    {
        /// <summary>
        /// Новый пароль пользователя
        /// </summary>
        [Required(ErrorMessage = "Заполните поле.")]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&*])[A-Za-z\d!@#$%^&*]{8,}$", ErrorMessage = "Пароль не соответствует требованиям.")]

        public string Password { get; set; }

        /// <summary>
        /// Повторить пароль
        /// </summary>
        [Required(ErrorMessage = "Заполните поле.")]
        [Compare("Password", ErrorMessage = "Пароли не совпадают.")]
        public string ConfirmPassword { get; set; }
    }
}
