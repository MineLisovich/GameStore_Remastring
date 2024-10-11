using GameStore.BLL.DTO.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GameStore.WEB.Areas.Admin.Models.UserManagerModels
{
    public class DataUserManagerModel
    {
        public AppUserDTO AppUser { get; set; }

        public SelectList SelectListItems_Roles { get; set; }
    }
}
