using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Storage.Contexts;
using Storage.Entities;

namespace Storage.Repositories.Boxes;

internal class BoxRepository : IBoxRepository
{
    private readonly StorageContext storageContext;
    private readonly IMapper mapper;

    public BoxRepository(StorageContext storageContext, IMapper mapper)
    {
        this.storageContext = storageContext;
        this.mapper = mapper;
    }

    public async Task<Guid?> CreateAsync(Box box, CancellationToken cancellationToken)
    {
        using var transaction = storageContext.Database.BeginTransaction();

        await storageContext.Boxes.AddAsync(box, cancellationToken);
        await storageContext.SaveChangesAsync(cancellationToken);

        transaction.Commit();

        return box.Id;
    }

    public async Task<bool> DeleteAsync(Guid boxId, CancellationToken cancellationToken)
    {
        using var transaction = storageContext.Database.BeginTransaction();

        var storedBox = storageContext.Boxes.FirstOrDefault(p => p.Id == boxId);

        if (storedBox == null)
        {
            transaction.Rollback();
            return false;
        }

        storageContext.Boxes.Remove(storedBox);
        await storageContext.SaveChangesAsync(cancellationToken);

        transaction.Commit();

        return true;
    }

    public Task<List<Box>> GetAllAsync(CancellationToken cancellationToken)
    {
        return storageContext.Boxes.ToListAsync(cancellationToken);
    }

    public Task<Box?> GetAsync(Guid id, CancellationToken cancellationToken)
    {
        return storageContext.Boxes.FirstOrDefaultAsync(b => b.Id == id, cancellationToken);
    }

    public async Task<bool> UpdateAsync(Box box, CancellationToken cancellationToken)
    {
        using var transaction = storageContext.Database.BeginTransaction();

        var storedBox = storageContext.Boxes.FirstOrDefault(p => p.Id == box.Id);

        if (storedBox == null)
        {
            transaction.Rollback();
            return false;
        }

        mapper.Map(box, storedBox);
        await storageContext.SaveChangesAsync(cancellationToken);

        transaction.Commit();

        return true;
    }
}
