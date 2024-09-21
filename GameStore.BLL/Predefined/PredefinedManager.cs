using GameStore.DAL.Predefined.Identity;

namespace GameStore.BLL.Predefined
{
    /// <summary>
    /// Точка входа к предзаданным значениям
    /// </summary>
    public class PredefinedManager
    {
        private PdRoles? _roleNames;

        /// <summary>
        /// Роли в системе
        /// </summary>
        public PdRoles AppRole
        {
            get
            {
                if(_roleNames is null)
                {
                    _roleNames = new PdRoles();
                }
                return _roleNames;
            }
        }
    }
}
