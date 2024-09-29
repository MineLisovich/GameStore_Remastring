using System.ComponentModel.DataAnnotations;

namespace GameStore.WEB.Models.AccountModels
{
    /// <summary>
    /// Модель для ввода 6ти значного кода, который приходит на эл. почту
    /// </summary>
    public class Account2FAModel
    {
        /// <summary>
        /// Код подтверждения
        /// </summary>
        [Required(ErrorMessage = "Поле обязательно для заполнения!")]
        public string Code { get; set; }
    }
}
