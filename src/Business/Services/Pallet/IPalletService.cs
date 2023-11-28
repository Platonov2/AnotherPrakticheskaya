using Business.Models;

namespace Business.Services.Pallet;

public interface IPalletService : ICrudService<PalletDomain>
{

    public Task<ICollection<PalletDomain>> GetWithPaginationAsync(
        int offset,
        int take,
        CancellationToken cancellationToken);
}
