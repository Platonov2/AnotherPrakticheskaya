using Microsoft.EntityFrameworkCore;
using Storage.Contexts;
using Storage.Entities;

namespace Storage.Repositories.Boxes;

internal sealed class BoxRepository : IBoxRepository
{
    private readonly StorageContext storageContext;

    public BoxRepository(StorageContext storageContext)
    {
        this.storageContext = storageContext;
    }

    public async Task<Guid?> CreateAsync(BoxRecord box, CancellationToken cancellationToken)
    {
        await storageContext.Boxes.AddAsync(box, cancellationToken);
        await storageContext.SaveChangesAsync(cancellationToken);

        return box.Id;
    }

    public async Task DeleteAsync(BoxRecord box, CancellationToken cancellationToken)
    {
        storageContext.Boxes.Remove(box);
        await storageContext.SaveChangesAsync(cancellationToken);
    }

    public Task<List<BoxRecord>> GetAllAsync(CancellationToken cancellationToken)
    {
        return storageContext.Boxes.ToListAsync(cancellationToken);
    }

    public Task<BoxRecord?> GetAsync(Guid id, CancellationToken cancellationToken)
    {
        return storageContext.Boxes.FirstOrDefaultAsync(b => b.Id == id, cancellationToken);
    }

    public async Task UpdateAsync(BoxRecord box, CancellationToken cancellationToken)
    {
        storageContext.Update(box);
        await storageContext.SaveChangesAsync(cancellationToken);
    }
}
