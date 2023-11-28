namespace Business.Services;

/// <summary>
/// Интерфейс сервиса, реализующего CRUD-операции
/// </summary>
public interface ICrudService<T>
    where T : class
{
    /// <summary>
    /// Получение сущности по Id
    /// </summary>
    public Task<T?> GetAsync(Guid entityId, CancellationToken cancellationToken);

    /// <summary>
    /// Создание сущности
    /// </summary>
    public Task<Guid?> CreateAsync(T entity, CancellationToken cancellationToken);

    /// <summary>
    /// Обновление сущности
    /// </summary>
    public Task<bool> UpdateAsync(T entity, CancellationToken cancellationToken);

    /// <summary>
    /// Удаление сущности
    /// </summary>
    public Task DeleteAsync(Guid entityId, CancellationToken cancellationToken);
}
