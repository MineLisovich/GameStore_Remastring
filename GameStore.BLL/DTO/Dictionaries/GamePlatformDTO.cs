using GameStore.BLL.DTO.Games;

namespace GameStore.BLL.DTO.Dictionaries
{
    /// <summary>
    /// Игровые платформы DTO
    /// </summary>
    public class GamePlatformDTO
    {

        public int Id { get; set; }

        /// <summary>
        /// Наименование платформы
        /// </summary>
        public required string Name { get; set; }
        public List<GameDTO> Games { get; set; } = new();
    }
}
