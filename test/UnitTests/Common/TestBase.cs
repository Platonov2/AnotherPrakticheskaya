using AutoFixture.AutoMoq;
using AutoFixture;
using Business.Services.Pallet;
using Business.Services.Box;
using Moq;
using Storage.Repositories.Boxes;
using Storage.Repositories.Pallets;
using AutoMapper;
using Api.Automapper;
using Business.Infrastructure.Automapper;
using Api.Controllers.Boxes.Validators;
using Api.Controllers.Pallets.Validators;

namespace UnitTests.Common;

public class TestBase
{
    protected readonly Mock<IPalletRepository> PalletRepositoryMock;
    protected readonly Mock<IBoxRepository> BoxRepositoryMock;
    protected readonly IFixture Fixture = new Fixture().Customize(new AutoMoqCustomization());

    public TestBase()
    {
        PalletRepositoryMock = Fixture.Freeze<Mock<IPalletRepository>>();
        BoxRepositoryMock = Fixture.Freeze<Mock<IBoxRepository>>();

        Fixture.Register<IPalletService>(() => Fixture.Create<PalletService>());
        Fixture.Register<IBoxService>(() => Fixture.Create<BoxService>());
        Fixture.Register<CreatePalletValidator>(() => Fixture.Create<CreatePalletValidator>());

        Fixture.Register(() => new MapperConfiguration(c =>
        {
            c.AddProfile(new ResponceMappingProfile());
            c.AddProfile(new BoxMappingProfile());
            c.AddProfile(new StorageMappingProfile());
        }).CreateMapper());
    }
}
