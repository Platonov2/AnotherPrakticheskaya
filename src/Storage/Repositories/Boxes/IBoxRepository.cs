using Storage.Entities;

namespace Storage.Repositories.Boxes;

/// <summary>
/// Интерфейс репозитория коробок
/// </summary>
public interface IBoxRepository : ICrudRepository<BoxRecord>
{
    /// <summary>
    /// Получение всех коробок из БД
    /// </summary>
    public Task<List<BoxRecord>> GetAllAsync(CancellationToken cancellationToken);
}
