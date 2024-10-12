namespace GameStore.BLL.DTO.Games
{

    /// <summary>
    /// Скриншоты игр DTO
    /// </summary>
    public class GameScreenshotDTO
    {
        public long Id { get; set; }

        /// <summary>
        /// Скриншот
        /// </summary>
        public byte[] Screenshot { get; set; } = null;

        /// <summary>
        /// Наименование скиншота
        /// </summary>
        public string ScreenshotName { get; set; } = null;

        /// <summary>
        /// Id Игры
        /// </summary>
        public long GameId { get; set; }

        /// <summary>
        /// Игра
        /// </summary>
        public GameDTO Game { get; set; } = null;
    }
}
