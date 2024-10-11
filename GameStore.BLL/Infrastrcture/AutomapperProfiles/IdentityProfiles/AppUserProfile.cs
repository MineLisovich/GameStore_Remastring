using AutoMapper;
using GameStore.BLL.DTO.Identity;
using GameStore.BLL.Infrastrcture.AutoMapperResolvers.IdentityResolvers.DALtoBLL;
using GameStore.DAL.Entities.Identity;

namespace GameStore.BLL.Infrastrcture.AutomapperProfiles.IdentityProfiles
{
    public class AppUserProfile : Profile
    {
        public AppUserProfile() 
        { 
            CreateMap<AppUser,AppUserDTO>()
             .ForMember(dest => dest.IsBanned, opt => opt.MapFrom(new AppUserDTO_IsBannedResolver()))
             .ForMember(dest => dest.LockoutEnd, opt => opt.MapFrom(src => src.LockoutEnd.HasValue ? TimeZoneInfo.ConvertTimeFromUtc(src.LockoutEnd.Value.UtcDateTime, TimeZoneInfo.FindSystemTimeZoneById("Belarus Standard Time")) : (DateTime?)null));


            CreateMap<AppUserDTO, AppUser>();
        }
    }
}
