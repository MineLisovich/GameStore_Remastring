namespace GameStore.BLL.Infrastrcture
{
    /// <summary>
    /// Стандартные ошибки 
    /// </summary>
    internal class DefaultErrorMessages
    {
        /// <summary>
        /// Ошибка: Не удалось сохранить данные в базе данных
        /// </summary>
        internal const string dontSave = "Не удалось сохранить запись.";
        /// <summary>
        /// Ошибка: Такая запись уже существует
        /// </summary>
        internal const string recordExist = "Такая запись уже существует";

        /// <summary>
        /// Ошибка: Такой записи не существует
        /// </summary>
        internal const string recordNoExist = "Такой записи не существует";

        /// <summary>
        /// Ошибка: Вы пытаетесь изменить текущую запись на уже существующую
        /// </summary>
        internal const string clone = "Вы пытаетесь изменить текущую запись на уже существующую";
    }
}
