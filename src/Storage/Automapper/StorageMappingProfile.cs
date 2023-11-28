using AutoMapper;
using Storage.Entities;

namespace Business.Infrastructure.Automapper;

public class StorageMappingProfile : Profile
{
    public StorageMappingProfile()
    {
        CreateMap<Pallet, Pallet>()
            .ForAllMembers(opts => opts.Condition((_, _, srcMember) => srcMember != null));

        CreateMap<Box, Box>()
            .ForMember(dest => dest.PalletId, opt => opt.Ignore())
            .ForAllMembers(opts => opts.Condition((_, _, srcMember) => srcMember != null));
    }
}
