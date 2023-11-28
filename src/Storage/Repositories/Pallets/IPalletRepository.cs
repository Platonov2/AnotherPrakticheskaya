using Storage.Entities;

namespace Storage.Repositories.Pallets;

/// <summary>
/// Интерфейс репозитория паллет
/// </summary>
public interface IPalletRepository : ICrudRepository<PalletRecord>
{
    /// <summary>
    /// Получение всех паллет из БД
    /// </summary>
    public Task<List<PalletRecord>> GetAllAsync(CancellationToken cancellationToken);

    /// <summary>
    /// Получение паллет с паггинацией
    /// </summary>
    public Task<List<PalletRecord>> GetWithPaginationAsync(
        int offset,
        int take,
        CancellationToken cancellationToken);
}
