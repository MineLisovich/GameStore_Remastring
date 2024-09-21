using AutoMapper;
using GameStore.BLL.DTO.Identity;
using GameStore.DAL.Entities.Identity;

namespace GameStore.BLL.Infrastrcture.AutomapperProfiles.IdentityProfiles
{
    public class AppUserProfile : Profile
    {
        public AppUserProfile() 
        { 
            CreateMap<AppUser,AppUserDTO>().ReverseMap();
        }
    }
}
