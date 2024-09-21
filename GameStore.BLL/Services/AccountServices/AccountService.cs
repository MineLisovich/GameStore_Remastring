using GameStore.BLL.Predefined;
using GameStore.DAL.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace GameStore.BLL.Services.AccountServices
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<AppUser> _userManager;
        public  AccountService(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        /// <summary>
        /// Регистрация пользователя в системе
        /// </summary>
        /// <param name="email">Эл. почта пользователя</param>
        /// <param name="password">Пароль</param>
        /// <returns>true or false</returns>
        public async Task<AppUser> CreateAccountAsync(string email, string password)
        {
            PredefinedManager pd = new();

            AppUser user = new()
            {
                Email = email,
                UserName = email,
                EmailConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnabled = true,
                LockoutEnd = null,
                UserRoleName = pd.AppRole.user.Name,
                LastVisit = DateTime.UtcNow,
            };
            IdentityResult result_create = await _userManager.CreateAsync(user, password);
            IdentityResult result_addRole = await _userManager.AddToRoleAsync(user, user.UserRoleName);

            if(result_create.Succeeded && result_addRole.Succeeded)
            {
                return user;
            }
            return null;

        }
    }
}
