using GameStore.BLL.DTO.Dictionaries;
using GameStore.WEB.Infrastrcture;

namespace GameStore.WEB.Areas.Admin.Models.DictionariesModels
{
    public class ShowDictionatyModel
    {

        public List<GenreDTO> Genres { get; set; }
        public List<GameDeveloperDTO> GameDevelopers { get; set; }
        public List<GamePlatformDTO> GamePlatforms { get; set; }
        public List<GameLabelDTO> GameLabels { get; set; }

        public UserActionResult LastAction { get; set; }

        public string DictionaryName { get; set; }
    }
}
