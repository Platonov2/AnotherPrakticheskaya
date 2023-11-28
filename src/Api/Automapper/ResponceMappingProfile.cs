using Api.Controllers.Boxes.Requests;
using Api.Controllers.Boxes.Responces;
using Api.Controllers.Pallets.Requests;
using Api.Controllers.Pallets.Responces;
using AutoMapper;
using Business.Models;

namespace Api.Automapper;

public class ResponceMappingProfile : Profile
{
    public ResponceMappingProfile()
    {
        CreateMap<Box, GetBoxResponce>();

        CreateMap<Pallet, GetPalletResponce>();

        CreateMap<CreateBoxRequest, Box>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid()));

        CreateMap<CreatePalletRequest, Pallet>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid()));

        CreateMap<UpdateBoxRequest, Box>();

        CreateMap<UpdatePalletRequest, Pallet>();
    }
}
