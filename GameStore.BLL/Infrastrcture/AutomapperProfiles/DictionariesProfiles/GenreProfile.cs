using AutoMapper;
using GameStore.BLL.DTO.Dictionaries;
using GameStore.DAL.Entities.Dictionaries;

namespace GameStore.BLL.Infrastrcture.AutomapperProfiles.DictionariesProfiles
{
    public class GenreProfile : Profile
    {
        public GenreProfile() 
        { 
            CreateMap<Genre, GenreDTO>().ReverseMap();
        }
    }
}
