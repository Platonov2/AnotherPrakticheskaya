using Microsoft.EntityFrameworkCore;
using Storage.Contexts;
using Storage.Entities;

namespace Storage.Repositories.Pallets;

internal class PalletRepository : IPalletRepository
{
    private readonly StorageContext storageContext;

    public PalletRepository(StorageContext storageContext)
    {
        this.storageContext = storageContext;
    }

    public Task<List<PalletRecord>> GetAllAsync(CancellationToken cancellationToken)
    {
        return storageContext.Pallets.Include(p => p.Boxes).ToListAsync(cancellationToken);
    }

    public Task<PalletRecord?> GetAsync(Guid id, CancellationToken cancellationToken)
    {
        return storageContext.Pallets.Include(p => p.Boxes).FirstOrDefaultAsync(p => p.Id == id, cancellationToken);
    }

    public async Task<Guid?> CreateAsync(PalletRecord pallet, CancellationToken cancellationToken)
    {
        await storageContext.Pallets.AddAsync(pallet, cancellationToken);
        await storageContext.SaveChangesAsync(cancellationToken);

        return pallet.Id;
    }

    public async Task UpdateAsync(PalletRecord pallet, CancellationToken cancellationToken)
    {
        storageContext.Update(pallet);
        await storageContext.SaveChangesAsync(cancellationToken);
    }

    public async Task DeleteAsync(PalletRecord pallet, CancellationToken cancellationToken)
    {
        storageContext.Pallets.Remove(pallet);
        await storageContext.SaveChangesAsync(cancellationToken);
    }

    public async Task<List<PalletRecord>> GetWithPaginationAsync(int offset, int take, CancellationToken cancellationToken)
    {
        var pallets = await storageContext.Pallets.Include(p => p.Boxes).ToListAsync(cancellationToken);

        return pallets.Skip(offset).Take(take).ToList();
    }
}
