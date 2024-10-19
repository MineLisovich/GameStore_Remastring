using GameStore.BLL.Infrastrcture;
using GameStore.DAL.Domain;
using Microsoft.EntityFrameworkCore;

namespace GameStore.BLL.Services.DictionariesServices
{
    /// <summary>
    /// Generic сервис для управления словорями
    /// </summary>
    /// <typeparam name="T">Источник(DAL)</typeparam>
    public class GenericDictionaryService<T> : IGenericDictionaryService<T> where T : class
    {
        private readonly GsDbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericDictionaryService(GsDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        /// <summary>
        /// Полусить все данные
        /// </summary>
        public async Task<List<T>> GetAllDataAsync()
        {
            return await _dbSet.ToListAsync();
        }

        /// <summary>
        /// Получить данные по Id
        /// </summary>
        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        /// <summary>
        /// Создать новую запись
        /// </summary>
        public async Task<ResultServiceModel> AddAsync(T entity)
        {
            ResultServiceModel result = new();

            try
            {
                await _dbSet.AddAsync(entity);
                await _context.SaveChangesAsync();
            }
            catch { result.IsSucceeded = false; result.ErrorMes = DefaultErrorMessages.dontSave; return result; }

            result.IsSucceeded = true;
            return result;

        }

        /// <summary>
        /// Изменеить запись
        /// </summary>
        public async Task<ResultServiceModel> UpdateAsync(T entity)
        {
            ResultServiceModel result = new();
            try
            {
                _context.Entry(entity).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch { result.IsSucceeded = false; result.ErrorMes = DefaultErrorMessages.dontSave; return result; }

            result.IsSucceeded = true;
            return result;
        }

        /// <summary>
        /// Удалить запись
        /// </summary>
        public async Task<ResultServiceModel> DeleteAsync(int id)
        {
            ResultServiceModel result = new();
            T entity = await _dbSet.FindAsync(id);
            try
            {
                _dbSet.Remove(entity);
                await _context.SaveChangesAsync();
            }
            catch { result.IsSucceeded = false; result.ErrorMes = DefaultErrorMessages.dontSave; return result; }
            result.IsSucceeded = true;
            return result;
        }
    }
}
