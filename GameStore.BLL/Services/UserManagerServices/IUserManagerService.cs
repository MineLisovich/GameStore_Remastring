using GameStore.BLL.DTO.Identity;
using GameStore.BLL.Infrastrcture;

namespace GameStore.BLL.Services.UserManagerServices
{
    public interface IUserManagerService
    {
        /// <summary>
        /// Получить весь список пользователей
        /// </summary>
        /// <returns>Список пользователей</returns>
        Task<List<AppUserDTO>> GetAllAppUserAsync();

        /// <summary>
        /// Получить пользователя по Email
        /// </summary>
        /// <param name="userId">Email пользователя</param>
        /// <returns>Пользователь</returns>
        Task<AppUserDTO> GetAppUserByEmailAsync(string userId);

        /// <summary>
        /// Создание нового пользователя
        /// </summary>
        /// <param name="appUserDTO">Заполненная модель</param>
        /// <returns>Результат действия сервиса (true || false)</returns>
        Task<ResultServiceModel> GreateUserAsync(AppUserDTO appUserDTO);

        /// <summary>
        /// Редактирование существующего пользователя
        /// </summary>
        /// <param name="currentUserEmail">Email текущего пользователя</param>
        /// <param name="appUserDTO">Заполненная модель</param>
        /// <returns>Результат действия сервиса (true || false)</returns>
        Task<ResultServiceModel> UpdateUserAsync(string currentUserEmail, AppUserDTO appUserDTO);

        /// <summary>
        /// Удаление аккаунта пользователя
        /// </summary>
        /// <param name="currentUserEmail">Email текущего пользователя</param>
        /// <param name="userId">Email пользователя</param>
        /// <returns>Результат действия сервиса (true || false)</returns>
        Task<ResultServiceModel> DeleteUserAsync(string currentUserEmail, string userId);
    }
}
