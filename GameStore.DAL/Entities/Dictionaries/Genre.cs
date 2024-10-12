using GameStore.DAL.Entities.Games;

namespace GameStore.DAL.Entities.Dictionaries
{
    /// <summary>
    /// Жанры игр
    /// </summary>
    public class Genre
    {
        public int Id { get; set; }
        
        /// <summary>
        /// Наименование жанра
        /// </summary>
        public required string Name { get; set; }

        public List<Game> Games { get; set; } = new();
    }
}
