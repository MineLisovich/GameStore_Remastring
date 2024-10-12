using GameStore.DAL.Entities.Games;

namespace GameStore.DAL.Entities.Dictionaries
{
    /// <summary>
    /// Ярлыки игры (типо PVE PVP Coop и пр.)
    /// </summary>
    public class GameLabel
    {
        public int Id { get; set; }
      
        /// <summary>
        /// Наименование ярлыка
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// Игры
        /// </summary>
        public List<Game> Games { get; set; } = new();
    }
}
