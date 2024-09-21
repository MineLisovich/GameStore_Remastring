namespace GameStore.WEB.Infrastrcture
{

    /// <summary>
    /// Стандартные действия пользователя в системе
    /// </summary>
    public class ServiceVariablesClasses
    {
        /// <summary>
        /// Создание
        /// </summary>
        public readonly UserActionResult Create = new() { Id = 1, Name = "создание" };

        /// <summary>
        /// Изменение
        /// </summary>
        public readonly UserActionResult Edit = new() { Id = 2, Name = "изменение" };

        /// <summary>
        /// Удаление
        /// </summary>
        public readonly UserActionResult Delete = new() { Id = 3, Name = "удаление" };

        /// <summary>
        /// Оповещение
        /// </summary>
        public readonly UserActionResult Notify = new() { Id = 4, Name = "оповещение" };

        /// <summary>
        /// Смена пароля
        /// </summary>
        public readonly UserActionResult PasswordChange = new() { Id = 5, Name = "смена пароля" };
    }
}
