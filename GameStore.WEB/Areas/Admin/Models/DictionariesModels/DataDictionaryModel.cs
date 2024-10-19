using GameStore.BLL.DTO.Dictionaries;

namespace GameStore.WEB.Areas.Admin.Models.DictionariesModels
{
    public class DataDictionaryModel
    {
        public GenreDTO Genre { get; set; }
        public GameDeveloperDTO GameDeveloper { get; set; }
        public GamePlatformDTO GamePlatform { get; set; }   
        public GameLabelDTO GameLabel { get; set; } 
      
        //Технические поля
        public string TitleNameForm { get; set; }
        public int SectionOrderId { get; set; }
        public bool IsCreateMode { get; set; }

    }
}
