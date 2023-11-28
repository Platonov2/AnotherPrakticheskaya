using AutoFixture;
using AutoMapper;
using UnitTests.Common;
using Xunit;
using Api.Controllers.Boxes;
using Business.Services.Box;
using Api.Controllers.Boxes.Validators;

using static UnitTests.Controllers.Boxes.DataGenerator;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;

namespace UnitTests.Controllers.Boxes;

public class BoxControllerTests : TestBase
{
    private readonly BoxController sut;

    public BoxControllerTests()
    {
        sut = new BoxController(
            Fixture.Create<IBoxService>(),
            new CreateBoxValidator(),
            new UpdateBoxValidator(),
            Fixture.Create<IMapper>());
    }

    [Fact(DisplayName = "Невозможность обновления несуществующего направления")]
    public async void CreateBox_WithLengthLessZero_ShoudException()
    {
        // Arrange
        var boxDto = GenerateCreateBoxDto(minLength: int.MinValue, maxLength: 0);

        // Act
        var result = await sut.Create(boxDto, CancellationToken.None);

        // Assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
}
