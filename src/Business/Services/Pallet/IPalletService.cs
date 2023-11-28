namespace Business.Services.Pallet;

/// <summary>
/// Интерфейс сервиса паллет
/// </summary>
public interface IPalletService : ICrudService<Models.Pallet>
{
    public Task<ICollection<Models.Pallet>> GetAllAsync(CancellationToken cancellationToken);

    public Task<ICollection<Models.Pallet>> GetWithPaginationAsync(
        int offset,
        int take,
        CancellationToken cancellationToken);
}
