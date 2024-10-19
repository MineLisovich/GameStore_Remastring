namespace GameStore.WEB.Infrastrcture
{
    /// <summary>
    /// Класс который содержит типы словорей (Жанры, Разработчики, Платформы, Особенности игр)
    /// </summary>
    public class DictionariesTypes
    {
        /// <summary>
        /// Класс который описывает тип словаря
        /// </summary>
        public class DictionaryType
        {
            public int OrderId { get; set; }
            public string RuName { get; set; }
            public string SectionName { get; set; }
        }

        /// <summary>
        /// Словарь: Жанры игр
        /// </summary>
        public readonly DictionaryType d_genre = new() { OrderId = 1, RuName = "Жанры игр", SectionName = "d_genre" };

        /// <summary>
        /// Словарь: Разработчики игр
        /// </summary>
        public readonly DictionaryType d_gamDev = new() { OrderId = 2, RuName = "Разработчики игр", SectionName = "d_gamDev" };

        /// <summary>
        /// Словарь: Игровые платформы
        /// </summary>
        public readonly DictionaryType d_gamPlat = new() { OrderId = 3, RuName = "Игровые платформы", SectionName = "d_gamPlat" };

        /// <summary>
        /// Словарь: Особенности игр
        /// </summary>
        public readonly DictionaryType d_gamLabel = new() { OrderId = 4, RuName = "Особенности игр", SectionName = "d_gamLabl" };

        /// <summary>
        /// Список словорей
        /// </summary>
        public List<DictionaryType> DictionaryTypesList;

        public DictionariesTypes()
        {
            DictionaryTypesList = new()
            {
                d_genre, d_gamDev, d_gamPlat, d_gamLabel
            };
        }
    }
}      