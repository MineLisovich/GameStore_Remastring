using GameStore.DAL.Entities.Identity;

namespace GameStore.BLL.DTO.Identity
{
    public class AppUserDTO : AppUser
    {
        //Технические поля
        public bool IsChangeEmail { get; set; }

        public bool IsBanned { get; set; }  
    }
}
