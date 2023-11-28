using AutoMapper;
using Business.Models;
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

    public async Task<ICollection<PalletDomain>> GetAllAsync(CancellationToken cancellationToken)
    {
        var palletEntities = await palletRepository.GetAllAsync(cancellationToken).ConfigureAwait(false);

        return MapPalletsWithBoxes(palletEntities);
    }

    public async Task<PalletDomain?> GetAsync(Guid id, CancellationToken cancellationToken)
    {
        var palletEntity = await palletRepository.GetAsync(id, cancellationToken).ConfigureAwait(false);

        if (palletEntity == null)
        {
            return null;
        }

        return MapPalletWithBoxes(palletEntity);
    }

    public Task<Guid?> CreateAsync(PalletDomain palletDomain, CancellationToken cancellationToken)
    {
        var pallet = mapper.Map<Storage.Entities.Pallet>(palletDomain);

        return palletRepository.CreateAsync(pallet, cancellationToken);
    }

    public Task<bool> UpdateAsync(PalletDomain palletDomain, CancellationToken cancellationToken)
    {
        var pallet = mapper.Map<Storage.Entities.Pallet>(palletDomain);

        return palletRepository.UpdateAsync(pallet, cancellationToken);
    }

    public Task<bool> DeleteAsync(Guid palletId, CancellationToken cancellationToken)
    {
        return palletRepository.DeleteAsync(palletId, cancellationToken);
    }

    public async Task<ICollection<PalletDomain>> GetWithPaginationAsync(
        int offset,
        int take,
        CancellationToken cancellationToken)
    {
        var palletEntities = await palletRepository.GetWithPaginationAsync(offset, take, cancellationToken)
            .ConfigureAwait(false);

        return MapPalletsWithBoxes(palletEntities);
    }

    private ICollection<PalletDomain> MapPalletsWithBoxes(ICollection<Storage.Entities.Pallet> pallets)
    {
        var domainPallets = new List<PalletDomain>();
        foreach (var palletEntity in pallets)
        {
            domainPallets.Add(MapPalletWithBoxes(palletEntity));
        }

        return domainPallets;
    }

    private PalletDomain MapPalletWithBoxes(Storage.Entities.Pallet pallet)
    {
        var boxes = mapper.Map<List<BoxDomain>>(pallet.Boxes);
        var domainPallet = mapper.Map<PalletDomain>(pallet);
        domainPallet.Boxes = boxes;

        return domainPallet;
    }
}
