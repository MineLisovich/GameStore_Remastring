using GameStore.DAL.Entities.Dictionaries;

namespace GameStore.DAL.Predefined.Dictionaries
{
    /// <summary>
    /// Игровые платформы. Предзаданные значения
    /// </summary>
    public class PdGamePlatforms
    {
        public GamePlatform pl1 = new() { Id = 1, Name = "Steam" };
        public GamePlatform pl2 = new() { Id = 2, Name = "Epic Launcher" };
        public GamePlatform pl3 = new() { Id = 3, Name = "Battle.net" };
        public GamePlatform pl4 = new() { Id = 4, Name = "Origin" };
        public GamePlatform pl5 = new() { Id = 5, Name = "Uplay" };
        public GamePlatform pl6 = new() { Id = 6, Name = "Rockstar Games Launcher" };

        public List<GamePlatform> ListGamePlatforms;

        public  PdGamePlatforms()
        {
            ListGamePlatforms = new()
            {
                pl1, pl2, pl3, pl4, pl5, pl6
            };
        }
    }
}
