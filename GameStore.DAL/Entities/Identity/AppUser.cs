using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace GameStore.DAL.Entities.Identity
{
    public class AppUser : IdentityUser
    {
        /// <summary>
        /// Email пользователя
        /// </summary>
        [Required(ErrorMessage = "Поле обязательно для заполнения!")]
        [EmailAddress(ErrorMessage = "Е-mail введен некорректно!")]
        public override string? Email { get; set; }

        /// <summary>
        /// Аватарка пользователя - изоображение
        /// </summary>
        public byte[]? AvatarImage { get; set; }
       
        /// <summary>
        /// Аватарка пользователя - имя картинки
        /// </summary>
        public string? AvatarName { get; set; }

        /// <summary>
        /// Последнее посещение
        /// </summary>
        public DateTime? LastVisit { get; set; }

        //Технические поля
        /// <summary>
        /// Роль пользователя
        /// </summary>
        public string? UserRoleName { get; set; }
    }
}
