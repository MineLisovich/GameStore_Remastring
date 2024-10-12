using System.ComponentModel.DataAnnotations.Schema;

namespace GameStore.DAL.Entities.Games
{
    /// <summary>
    /// Скриншоты игр
    /// </summary>
    public class GameScreenshot
    {
        public long Id { get; set; }

        /// <summary>
        /// Скриншот
        /// </summary>
        public byte[]? Screenshot { get; set; }
      
        /// <summary>
        /// Наименование скиншота
        /// </summary>
        public string? ScreenshotName { get; set; }

        /// <summary>
        /// Id Игры
        /// </summary>
        [ForeignKey(nameof(Game))]
        public long GameId { get; set; }
        
        /// <summary>
        /// Игра
        /// </summary>
        public Game? Game { get; set; }
    }
}
