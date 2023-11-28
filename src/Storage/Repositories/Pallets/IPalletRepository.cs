using Storage.Entities;

namespace Storage.Repositories.Pallets;

public interface IPalletRepository : ICrudRepository<Pallet>
{
    public Task<List<Pallet>> GetWithPaginationAsync(int offset, int take, CancellationToken cancellationToken);
}
