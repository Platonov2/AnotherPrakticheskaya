namespace Business.Services;

public interface ICrudService<T>
    where T : class
{
    public Task<ICollection<T>> GetAllAsync(CancellationToken cancellationToken);

    public Task<T?> GetAsync(Guid id, CancellationToken cancellationToken);

    public Task<Guid?> CreateAsync(T palletDomain, CancellationToken cancellationToken);

    public Task<bool> UpdateAsync(T palletDomain, CancellationToken cancellationToken);

    public Task<bool> DeleteAsync(Guid palletId, CancellationToken cancellationToken);
}
