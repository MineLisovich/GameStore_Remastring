namespace GameStore.BLL.DTO.Dictionaries
{
    /// <summary>
    /// Разработчик игр DTO
    /// </summary>
    public class GameDeveloperDTO
    {
        public int Id { get; set; }

        /// <summary>
        /// Наименование разработчика (компании)
        /// </summary>
        public string Name { get; set; }
    }
}
