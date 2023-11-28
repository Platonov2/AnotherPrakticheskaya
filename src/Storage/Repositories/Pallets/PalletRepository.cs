using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Storage.Contexts;
using Storage.Entities;

namespace Storage.Repositories.Pallets;

internal class PalletRepository : IPalletRepository
{
    private readonly StorageContext storageContext;
    private readonly IMapper mapper;

    public PalletRepository(StorageContext storageContext, IMapper mapper)
    {
        this.storageContext = storageContext;
        this.mapper = mapper;
    }

    public Task<List<Pallet>> GetAllAsync(CancellationToken cancellationToken)
    {
        return storageContext.Pallets.Include(p => p.Boxes).ToListAsync(cancellationToken);
    }

    public Task<Pallet?> GetAsync(Guid id, CancellationToken cancellationToken)
    {
        return storageContext.Pallets.Include(p => p.Boxes).FirstOrDefaultAsync(p => p.Id == id, cancellationToken);
    }

    public async Task<Guid?> CreateAsync(Pallet pallet, CancellationToken cancellationToken)
    {
        using var transaction = storageContext.Database.BeginTransaction();

        await storageContext.Pallets.AddAsync(pallet, cancellationToken);
        await storageContext.SaveChangesAsync(cancellationToken);

        transaction.Commit();

        return pallet.Id;
    }

    public async Task<bool> UpdateAsync(Pallet pallet, CancellationToken cancellationToken)
    {
        using var transaction = storageContext.Database.BeginTransaction();

        var storedPallet = storageContext.Pallets.FirstOrDefault(p => p.Id == pallet.Id);

        if (storedPallet == null)
        {
            transaction.Rollback();
            return false;
        }

        mapper.Map(pallet, storedPallet);
        await storageContext.SaveChangesAsync(cancellationToken);

        transaction.Commit();

        return true;
    }

    public async Task<bool> DeleteAsync(Guid palletId, CancellationToken cancellationToken)
    {
        using var transaction = storageContext.Database.BeginTransaction();

        var storedPallet = storageContext.Pallets.FirstOrDefault(p => p.Id == palletId);

        if (storedPallet == null)
        {
            transaction.Rollback();
            return false;
        }

        storageContext.Pallets.Remove(storedPallet);
        await storageContext.SaveChangesAsync(cancellationToken);

        transaction.Commit();

        return true;
    }

    public async Task<List<Pallet>> GetWithPaginationAsync(int offset, int take, CancellationToken cancellationToken)
    {
        var pallets = await storageContext.Pallets.Include(p => p.Boxes).ToListAsync(cancellationToken);

        return pallets.Skip(offset).Take(take).ToList();
    }
}
