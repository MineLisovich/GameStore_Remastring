using AutoMapper;
using GameStore.BLL.DTO.Identity;
using GameStore.DAL.Entities.Identity;

namespace GameStore.BLL.Infrastrcture.AutoMapperResolvers.IdentityResolvers.DALtoBLL
{
    public class AppUserDTO_IsBannedResolver : IValueResolver<AppUser, AppUserDTO, bool>
    {
        public bool Resolve(AppUser source, AppUserDTO dest, bool destMember, ResolutionContext context)
        {
            //false - активный; true - заблокирован
            return (source.LockoutEnd is null) ? false : true;
        }
    }
}
