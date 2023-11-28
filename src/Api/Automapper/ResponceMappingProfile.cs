using Api.Controllers.Boxes.RequestDtos;
using Api.Controllers.Boxes.ResponceDtos;
using Api.Controllers.Pallets.RequiestDtos;
using Api.Controllers.Pallets.ResponceDtos;
using AutoMapper;
using Business.Models;

namespace Api.Automapper;

public class ResponceMappingProfile : Profile
{
    public ResponceMappingProfile()
    {
        CreateMap<BoxDomain, GetBoxResponce>();

        CreateMap<PalletDomain, GetPalletResponceDto>();

        CreateMap<CreateBoxDto, BoxDomain>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid()));

        CreateMap<CreatePalletDto, PalletDomain>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid()));

        CreateMap<UpdateBoxDto, BoxDomain>()
            .ForAllMembers(opts => opts.Condition((_, _, srcMember) => srcMember != null));

        CreateMap<UpdatePalletDto, PalletDomain>()
            .ForAllMembers(opts => opts.Condition((_, _, srcMember) => srcMember != null));
    }
}
