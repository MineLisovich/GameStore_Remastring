using AutoMapper;
using GameStore.BLL.DTO.Identity;
using GameStore.DAL.Domain;
using GameStore.DAL.Entities.Identity;
using Microsoft.EntityFrameworkCore;

namespace GameStore.BLL.Services.UserProfileServices
{
    public class UserProfileService : IUserProfileService
    {
        private readonly GsDbContext _context;
        private readonly IMapper _mapper;
        public UserProfileService(GsDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<AppUserDTO> GetUserDataByEmailAsync(string email)
        {            
            AppUser user = await _context.AppUsers.Where(x=>x.Email == email).FirstOrDefaultAsync();
            if (user is null) {  return null; }

            AppUserDTO userDTO = _mapper.Map<AppUserDTO>(user);
            return userDTO;     
        }
    }
}
