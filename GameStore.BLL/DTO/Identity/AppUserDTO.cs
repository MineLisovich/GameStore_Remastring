using GameStore.DAL.Entities.Identity;

namespace GameStore.BLL.DTO.Identity
{
    public class AppUserDTO : AppUser
    {

        //
        public bool IsChangeEmail { get; set; }
    }
}
