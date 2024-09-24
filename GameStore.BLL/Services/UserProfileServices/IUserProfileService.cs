using GameStore.BLL.DTO.Identity;
using GameStore.BLL.Infrastrcture;
using Microsoft.AspNetCore.Http;

namespace GameStore.BLL.Services.UserProfileServices
{
    public interface IUserProfileService
    {
        Task<AppUserDTO> GetUserDataByEmailAsync(string email);
        Task<ResultServiceModel> EditUserProfileDataAsync(AppUserDTO userDTO, IFormFile uploadAvarar);
        Task<ResultServiceModel> ConfirmEmailAsync(string userId, string code);
        Task<ResultServiceModel> UnlinkEmailAsync(string email);
        Task<ResultServiceModel> EnableOrDisable2FAAsync(string email, bool isEnable);
    }
}
