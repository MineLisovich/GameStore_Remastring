using GameStore.BLL.Infrastrcture;
using System.Threading.Tasks;

namespace GameStore.BLL.Services.DictionariesServices
{
    /// <summary>
    /// IGeneric для управления словорями
    /// </summary>
    /// <typeparam name="T">Источник(DAL)</typeparam>
    public interface IGenericDictionaryService<T> where T : class
    {
        /// <summary>
        /// Получить все записи
        /// </summary>
        Task<List<T>> GetAllDataAsync();

        /// <summary>
        /// Получить запись по Id
        /// </summary>
        Task<T> GetByIdAsync(int id);

        /// <summary>
        /// Добавить новую запись
        /// </summary>
        Task<ResultServiceModel> AddAsync(T entity);

        /// <summary>
        /// Изменить запись
        /// </summary>
        Task<ResultServiceModel> UpdateAsync(T entity);

        /// <summary>
        /// Удалить запись
        /// </summary>
        Task<ResultServiceModel> DeleteAsync(int id);
    }
}
