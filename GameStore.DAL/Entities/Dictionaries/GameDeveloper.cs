namespace GameStore.DAL.Entities.Dictionaries
{
    /// <summary>
    /// Разработчик игр
    /// </summary>
    public class GameDeveloper
    {
        public int Id { get; set; }
        
        /// <summary>
        /// Наименование разработчика (компании)
        /// </summary>
        public required string Name { get; set; }
    }
}
