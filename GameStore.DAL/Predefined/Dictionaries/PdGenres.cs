using GameStore.DAL.Entities.Dictionaries;

namespace GameStore.DAL.Predefined.Dictionaries
{
    /// <summary>
    /// Жанры игр. Предзаданные значения
    /// </summary>
    public class PdGenres
    {
        public Genre action = new() { Id = 1, Name = "Экшн" };
        public Genre adventure = new() { Id = 2, Name = "Приключения" };
        public Genre rpg = new() { Id = 3, Name = "Ролевая игра (RPG)" };
        public Genre strategy = new() { Id = 4, Name = "Стратегия" };
        public Genre sports = new() { Id = 5, Name = "Спорт" };
        public Genre simulation = new() { Id = 6, Name = "Симулятор" };
        public Genre puzzle = new() { Id = 7, Name = "Головоломка" };
        public Genre fighting = new() { Id = 8, Name = "Драки" };
        public Genre racing = new() { Id = 9, Name = "Гонки" };
        public Genre shooter = new() { Id = 10, Name = "Шутер" };
        public Genre survival = new() { Id = 11, Name = "Выживание" };
        public Genre openWorld = new() { Id = 12, Name = "Открытый мир" };
        public Genre platformer = new() { Id = 13, Name = "Платформер" };
        public Genre horror = new() { Id = 14, Name = "Ужасы" };
        public Genre educational = new() { Id = 15, Name = "Образовательная игра" };

        public List<Genre> ListGanres;

        public PdGenres()
        {
            ListGanres = new()
            {
                action,adventure,rpg,strategy,sports,
                simulation,puzzle,fighting,racing,shooter,
                survival,openWorld,platformer,horror,educational
            };
        }
    }
}


