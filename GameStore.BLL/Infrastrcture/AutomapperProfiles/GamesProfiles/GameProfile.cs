using AutoMapper;
using GameStore.BLL.DTO.Games;
using GameStore.DAL.Entities.Games;

namespace GameStore.BLL.Infrastrcture.AutomapperProfiles.GamesProfiles
{
    public class GameProfile : Profile
    {
        public GameProfile() 
        { 
            CreateMap<Game, GameDTO>().ReverseMap();
        }
    }
}
