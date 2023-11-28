namespace Storage.Repositories;

public interface ICrudRepository<T>
    where T : class
{
    public Task<List<T>> GetAllAsync(CancellationToken cancellationToken);

    public Task<T?> GetAsync(Guid id, CancellationToken cancellationToken);

    public Task<Guid?> CreateAsync(T pallet, CancellationToken cancellationToken);

    public Task<bool> UpdateAsync(T pallet, CancellationToken cancellationToken);

    public Task<bool> DeleteAsync(Guid palletId, CancellationToken cancellationToken);
}
