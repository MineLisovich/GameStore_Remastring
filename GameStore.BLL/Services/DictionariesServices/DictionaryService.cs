
using AutoMapper;
using GameStore.BLL.Infrastrcture;

namespace GameStore.BLL.Services.DictionariesServices
{
    /// <summary>
    /// Сервис предназначенный для управления Словарями
    /// </summary>
    /// <typeparam name="T">Источник(DAL)</typeparam>
    /// <typeparam name="TDto">DTO (BLL)</typeparam>
    public class DictionaryService<T, TDto> where T : class where TDto : class
    {
        private readonly IMapper _mapper;
        private readonly IGenericDictionaryService<T> _repository;

        public DictionaryService(IGenericDictionaryService<T> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Получить все данные
        /// </summary>
        public async Task <List<TDto>> GetAllEntitiesAsync()
        {
            var entities = await _repository.GetAllDataAsync();
            return _mapper.Map<List<TDto>>(entities);
        }

        /// <summary>
        /// Получить данные по Id
        /// </summary>
        /// <param name="id">Id какого-то словоря</param>
        public async Task<TDto> GetEntityById(int id)
        {
            var entity = await _repository.GetByIdAsync(id);    
            return _mapper.Map<TDto>(entity);
        }

        /// <summary>
        /// Создать новую запись в словаре
        /// </summary>
        /// <param name="dto">DTO модель</param>
        public async Task<ResultServiceModel> CreateEntity(TDto dto)
        {
            var entity = _mapper.Map<T>(dto);
            ResultServiceModel result =  await _repository.AddAsync(entity);
            return result;
        }

        /// <summary>
        /// Изменить запись в словаре
        /// </summary>
        /// <param name="dto">DTO модель</param>
        public async Task<ResultServiceModel> UpdateEntity(TDto dto)
        {
            var entity = _mapper.Map<T>(dto);
            ResultServiceModel result = await _repository.UpdateAsync(entity);
            return result;
        }

        /// <summary>
        /// Удалить запись в словаре
        /// </summary>
        /// <param name="id">Id какого-то словоря</param>
        public async Task<ResultServiceModel> DeleteEntity(int id)
        {
            ResultServiceModel result = await _repository.DeleteAsync(id);
            return result;
        }
    }
}
