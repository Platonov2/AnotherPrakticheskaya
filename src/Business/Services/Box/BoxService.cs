using AutoMapper;
using Business.Models;
using Business.Services.Pallet;
using Storage.Repositories.Boxes;
using Storage.Repositories.Pallets;

namespace Business.Services.Box;

public sealed class BoxService : IBoxService
{
    private readonly IBoxRepository boxRepository;
    private readonly IPalletService palletService;
    private readonly IMapper mapper;

    public BoxService(IBoxRepository boxRepository, IPalletService palletService, IMapper mapper)
    {
        this.boxRepository = boxRepository;
        this.palletService = palletService;
        this.mapper = mapper;
    }

    public async Task<Guid?> CreateAsync(Models.Box boxDomain, CancellationToken cancellationToken)
    {
        var pallet = await palletService.GetAsync(boxDomain.PalletRecordId, cancellationToken);
        if (pallet == null)
        {
            return null;
        }

        var box = mapper.Map<Storage.Entities.BoxRecord>(boxDomain);

        return await boxRepository.CreateAsync(box, cancellationToken);
    }

    public async Task DeleteAsync(Guid boxId, CancellationToken cancellationToken)
    {
        var storedBox = await boxRepository.GetAsync(boxId, cancellationToken);
        if (storedBox != null)
        {
            await boxRepository.DeleteAsync(storedBox, cancellationToken);
        }
    }

    public async Task<ICollection<Models.Box>> GetAllAsync(CancellationToken cancellationToken)
    {
        var boxEntities = await boxRepository.GetAllAsync(cancellationToken).ConfigureAwait(false);

        return mapper.Map<ICollection<Models.Box>>(boxEntities);
    }

    public async Task<Models.Box?> GetAsync(Guid id, CancellationToken cancellationToken)
    {
        var boxEntity = await boxRepository.GetAsync(id, cancellationToken).ConfigureAwait(false);

        return mapper.Map<Models.Box>(boxEntity);
    }

    public async Task<bool> UpdateAsync(Models.Box boxDomain, CancellationToken cancellationToken)
    {
        var storedBox = await boxRepository.GetAsync(boxDomain.Id, cancellationToken);
        if (storedBox == null)
        {
            return false;
        }

        mapper.Map(boxDomain, storedBox);
        await boxRepository.UpdateAsync(storedBox, cancellationToken);

        return true;
    }
}
