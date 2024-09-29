namespace GameStore.WEB.Infrastrcture
{
    /// <summary>
    /// Модель для посторение ошибки
    /// </summary>
    public class NotFoundResultModel
    {
        /// <summary>
        /// Заголовок ошибки (пример: ошибка 404, 403 и тд)
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Сообщение о ошибке (пример: страница не была найдена)
        /// </summary>
        public string Subtitle { get; set; }

        /// <summary>
        /// Область куда будем перенаправлять пользователя
        /// </summary>
        public string AspArea { get; set; } = "";

        /// <summary>
        /// К какому контроллеру будет обращение
        /// </summary>
        public string AspController { get; set; }

        /// <summary>
        /// К какому методу в контроллере будет обрращение
        /// </summary>
        public string AspAction { get; set; }

        /// <summary>
        /// Текст для ссылки
        /// </summary>
        public string ATegText { get; set; }
    }
}
