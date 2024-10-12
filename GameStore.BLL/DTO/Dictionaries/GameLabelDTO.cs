using GameStore.BLL.DTO.Games;

namespace GameStore.BLL.DTO.Dictionaries
{

    /// <summary>
    /// Ярлыки игры (типо PVE PVP Coop и пр.) DTO
    /// </summary>
    public class GameLabelDTO
    {
        public int Id { get; set; }

        /// <summary>
        /// Наименование ярлыка
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// Игры
        /// </summary>
        public List<GameDTO> Games { get; set; } = new();
    }
}
