
namespace GameStore.BLL.Infrastrcture.Identity
{
    /// <summary>
    /// Политика доступа Identity
    /// </summary>
    public static class IdentityUserPolicy
    {
        /// <summary>
        /// Доступ только для Администратора
        /// </summary>
        public const string role_adminOnly = "А";

        /// <summary>
        /// Доступ только для Пользователя
        /// </summary>
        public const string role_UserOnly = "П";

        /// <summary>
        /// Доступ для Администратора и Пользователя
        /// </summary>
        public const string role_AdminUser = "АП";
    }
}
