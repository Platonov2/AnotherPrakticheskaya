using Api.Controllers.Pallets;
using Api.Controllers.Pallets.Validators;
using AutoFixture;
using AutoMapper;
using Business.Services.Pallet;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using UnitTests.Common;
using Xunit;

using static UnitTests.Controllers.Pallet.DataGenerator;

namespace UnitTests.Controllers.Pallets;

public class PalletControllerTests : TestBase
{
    private readonly PalletController sut;

    public PalletControllerTests()
    {
        sut = new PalletController(
            Fixture.Create<IPalletService>(),
            new CreatePalletValidator(),
            new UpdatePalletValidator(),
            Fixture.Create<IMapper>());
    }

    [Fact(DisplayName = "Невозможность обновления несуществующего направления")]
    public async void CreatePallet_WithLengthLessZero_ShoudException()
    {
        // Arrange
        var palletDto = GenerateCreatePalletDto(minLength: int.MinValue, maxLength: 0);

        // Act
        var result = await sut.Create(palletDto, CancellationToken.None);

        // Assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
}
