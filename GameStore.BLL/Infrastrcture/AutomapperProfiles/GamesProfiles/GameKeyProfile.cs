using AutoMapper;
using GameStore.BLL.DTO.Games;
using GameStore.DAL.Entities.Games;

namespace GameStore.BLL.Infrastrcture.AutomapperProfiles.GamesProfiles
{
    public class GameKeyProfile : Profile
    {
        public GameKeyProfile() 
        { 
            CreateMap<GameKey,GameKeyDTO>().ReverseMap();
        }
    }
}
