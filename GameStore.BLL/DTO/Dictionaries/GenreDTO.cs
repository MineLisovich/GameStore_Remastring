using GameStore.BLL.DTO.Games;

namespace GameStore.BLL.DTO.Dictionaries
{
    /// <summary>
    /// Жанры игр DTO
    /// </summary>
    public class GenreDTO
    {
        public int Id { get; set; }

        /// <summary>
        /// Наименование жанра
        /// </summary>
        public required string Name { get; set; }

        public List<GameDTO> Games { get; set; } = new();
    }
}
