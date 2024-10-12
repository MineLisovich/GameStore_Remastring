using AutoMapper;
using GameStore.BLL.DTO.Dictionaries;
using GameStore.DAL.Entities.Dictionaries;

namespace GameStore.BLL.Infrastrcture.AutomapperProfiles.DictionariesProfiles
{
    public class GameLabelProfile : Profile
    {
        public GameLabelProfile() 
        { 
            CreateMap<GameLabel, GameLabelDTO>().ReverseMap();
        }
    }
}
