using GameStore.BLL.DTO.Identity;

namespace GameStore.BLL.Services.UserProfileServices
{
    public interface IUserProfileService
    {
        Task<AppUserDTO> GetUserDataByEmailAsync(string email);
    }
}
