using Storage.Entities;

namespace Storage.Repositories;

/// <summary>
/// Интерфейс репозитория, реализующего CRUD-операции
/// </summary>
public interface ICrudRepository<T>
    where T : class
{
    /// <summary>
    /// Получение записи по Id
    /// </summary>
    public Task<T?> GetAsync(Guid recordId, CancellationToken cancellationToken);

    /// <summary>
    /// Создание записи
    /// </summary>
    public Task<Guid?> CreateAsync(T record, CancellationToken cancellationToken);

    /// <summary>
    /// Обновление записи
    /// </summary>
    public Task UpdateAsync(T record, CancellationToken cancellationToken);

    /// <summary>
    /// Удаление записи
    /// </summary>
    public Task DeleteAsync(T record, CancellationToken cancellationToken);
}
