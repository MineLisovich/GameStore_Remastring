namespace GameStore.WEB.Infrastrcture
{
    /// <summary>
    /// Результат дейсвия пользователя
    /// </summary>
    public class UserActionResult
    {
        /// <summary>
        /// Id действия
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Действие
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Результат действия
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// Дополнительная информация 
        /// </summary>
        public string DopInfo { get; set; }

        /// <summary>
        /// Id объекта, с которым проводилось действие
        /// </summary>
        public int ObjectId { get; set; }
    }
}
