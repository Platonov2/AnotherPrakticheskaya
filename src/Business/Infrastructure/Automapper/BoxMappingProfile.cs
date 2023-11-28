using AutoMapper;
using Business.Models;
using Storage.Entities;

namespace Business.Infrastructure.Automapper;

public class BoxMappingProfile : Profile
{
    public BoxMappingProfile()
    {
        CreateMap<BoxRecord, Box>();

        CreateMap<PalletRecord, Pallet>();

        CreateMap<Box, BoxRecord>();

        CreateMap<Pallet, PalletRecord>();
    }
}
