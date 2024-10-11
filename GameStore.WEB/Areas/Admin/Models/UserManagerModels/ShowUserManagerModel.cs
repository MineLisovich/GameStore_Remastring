using GameStore.BLL.DTO.Identity;
using GameStore.WEB.Infrastrcture;

namespace GameStore.WEB.Areas.Admin.Models.UserManagerModels
{
    public class ShowUserManagerModel
    {
        public List<AppUserDTO> AppUsers { get; set; }

        public UserActionResult LastAction { get; set; }
    }
}
