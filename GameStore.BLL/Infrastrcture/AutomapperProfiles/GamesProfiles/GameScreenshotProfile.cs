using AutoMapper;
using GameStore.BLL.DTO.Games;
using GameStore.DAL.Entities.Games;

namespace GameStore.BLL.Infrastrcture.AutomapperProfiles.GamesProfiles
{
    public class GameScreenshotProfile : Profile
    {
        public GameScreenshotProfile() 
        {
            CreateMap<GameScreenshot, GameScreenshotDTO>().ReverseMap();
        }
    }
}
