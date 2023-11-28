using AutoMapper;
using Storage.Repositories.Pallets;

namespace Business.Services.Pallet;

public sealed class PalletService : IPalletService
{
    private readonly IPalletRepository palletRepository;
    private readonly IMapper mapper;

    public PalletService(IPalletRepository palletRepository, IMapper mapper)
    {
        this.palletRepository = palletRepository;
        this.mapper = mapper;
    }

    public async Task<ICollection<Models.Pallet>> GetAllAsync(CancellationToken cancellationToken)
    {
        var palletEntities = await palletRepository.GetAllAsync(cancellationToken).ConfigureAwait(false);

        return MapPalletsWithBoxes(palletEntities);
    }

    public async Task<Models.Pallet?> GetAsync(Guid id, CancellationToken cancellationToken)
    {
        var palletEntity = await palletRepository.GetAsync(id, cancellationToken).ConfigureAwait(false);

        if (palletEntity == null)
        {
            return null;
        }

        return MapPalletWithBoxes(palletEntity);
    }

    public Task<Guid?> CreateAsync(Models.Pallet palletDomain, CancellationToken cancellationToken)
    {
        var pallet = mapper.Map<Storage.Entities.PalletRecord>(palletDomain);

        return palletRepository.CreateAsync(pallet, cancellationToken);
    }

    public async Task<bool> UpdateAsync(Models.Pallet palletDomain, CancellationToken cancellationToken)
    {
        var storedPallet = await palletRepository.GetAsync(palletDomain.Id, cancellationToken);

        if (storedPallet == null)
        {
            return false;
        }

        mapper.Map(palletDomain, storedPallet);
        await palletRepository.UpdateAsync(storedPallet, cancellationToken);

        return true;
    }

    public async Task DeleteAsync(Guid palletId, CancellationToken cancellationToken)
    {
        var storedPallet = await palletRepository.GetAsync(palletId, cancellationToken);

        if (storedPallet != null)
        {
            await palletRepository.DeleteAsync(storedPallet, cancellationToken);
        }
    }

    public async Task<ICollection<Models.Pallet>> GetWithPaginationAsync(
        int offset,
        int take,
        CancellationToken cancellationToken)
    {
        var palletEntities = await palletRepository.GetWithPaginationAsync(offset, take, cancellationToken)
            .ConfigureAwait(false);

        return MapPalletsWithBoxes(palletEntities);
    }

    private ICollection<Models.Pallet> MapPalletsWithBoxes(ICollection<Storage.Entities.PalletRecord> pallets)
    {
        var domainPallets = new List<Models.Pallet>();
        foreach (var palletEntity in pallets)
        {
            domainPallets.Add(MapPalletWithBoxes(palletEntity));
        }

        return domainPallets;
    }

    private Models.Pallet MapPalletWithBoxes(Storage.Entities.PalletRecord pallet)
    {
        var boxes = mapper.Map<List<Models.Box>>(pallet.Boxes);
        var domainPallet = mapper.Map<Models.Pallet>(pallet);
        domainPallet.Boxes = boxes;

        return domainPallet;
    }
}
