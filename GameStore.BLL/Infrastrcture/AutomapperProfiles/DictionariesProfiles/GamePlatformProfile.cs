using AutoMapper;
using GameStore.BLL.DTO.Dictionaries;
using GameStore.DAL.Entities.Dictionaries;

namespace GameStore.BLL.Infrastrcture.AutomapperProfiles.DictionariesProfiles
{
    public class GamePlatformProfile : Profile
    {
        public GamePlatformProfile() 
        {
            CreateMap<GamePlatform,GamePlatformDTO>().ReverseMap();
        }
    }
}
