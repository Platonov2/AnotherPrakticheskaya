using AutoMapper;
using Business.Models;
using Storage.Entities;

namespace Business.Infrastructure.Automapper;

public class BoxMappingProfile : Profile
{
    public BoxMappingProfile()
    {
        CreateMap<Box, BoxDomain>();

        CreateMap<Pallet, PalletDomain>();

        CreateMap<BoxDomain, Box>()
            .ForAllMembers(opts => opts.Condition((_, _, srcMember) => srcMember != null));

        CreateMap<PalletDomain, Pallet>()
            .ForAllMembers(opts => opts.Condition((_, _, srcMember) => srcMember != null));
    }
}
