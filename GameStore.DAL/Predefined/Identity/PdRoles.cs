using Microsoft.AspNetCore.Identity;
using System;

namespace GameStore.DAL.Predefined.Identity
{
    public class PdRoles
    {
        /// <summary>
        /// Роль: Администратор
        /// </summary>
        public IdentityRole admin = new()
        {
            Id = "admin",
            Name = "Администратор",
            NormalizedName = "АДМИНИСТРАТОР"
        };

        /// <summary>
        /// Роль: Пользователь
        /// </summary>
        public IdentityRole user = new()
        {
            Id = "user",
            Name = "Пользователь",
            NormalizedName = "ПОЛЬЗОВАТЕЛЬ"
        };

        /// <summary>
        /// Список ролей
        /// </summary>
        public readonly List<IdentityRole> RoleList;

        public PdRoles()
        {
            RoleList = new()
            {
              admin, user
            };
        }
    }
}
