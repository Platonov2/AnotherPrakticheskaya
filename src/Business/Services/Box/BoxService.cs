using AutoMapper;
using Business.Models;
using Business.Services.Pallet;
using Storage.Repositories.Boxes;

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

    public async Task<Guid?> CreateAsync(BoxDomain boxDomain, CancellationToken cancellationToken)
    {
        var pallet = await palletService.GetAsync(boxDomain.PalletId, cancellationToken);

        if (pallet == null)
        {
            return null;
        }

        var box = mapper.Map<Storage.Entities.Box>(boxDomain);

        return await boxRepository.CreateAsync(box, cancellationToken);
    }

    public Task<bool> DeleteAsync(Guid boxId, CancellationToken cancellationToken)
    {
        return boxRepository.DeleteAsync(boxId, cancellationToken);
    }

    public async Task<ICollection<BoxDomain>> GetAllAsync(CancellationToken cancellationToken)
    {
        var boxEntities = await boxRepository.GetAllAsync(cancellationToken).ConfigureAwait(false);

        return mapper.Map<List<BoxDomain>>(boxEntities);
    }

    public async Task<BoxDomain?> GetAsync(Guid id, CancellationToken cancellationToken)
    {
        var boxEntity = await boxRepository.GetAsync(id, cancellationToken).ConfigureAwait(false);

        return mapper.Map<BoxDomain>(boxEntity);
    }

    public Task<bool> UpdateAsync(BoxDomain boxDomain, CancellationToken cancellationToken)
    {
        var box = mapper.Map<Storage.Entities.Box>(boxDomain);

        return boxRepository.UpdateAsync(box, cancellationToken);
    }
}
