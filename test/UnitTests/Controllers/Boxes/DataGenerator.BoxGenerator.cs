using Api.Controllers.Boxes.Requests;

namespace UnitTests.Controllers.Boxes;

internal static partial class DataGenerator
{
    public static CreateBoxRequest GenerateCreateBoxDto(
        int minLength = 1,
        int maxLength = 1,
        int minHeight = 1,
        int maxHeight = 1,
        int minWidth = 1,
        int maxWidth = 1,
        int minWeight = 1,
        int maxWeight = 1,
        Guid palletId = default,
        DateOnly manufacturingDate = default,
        DateOnly expirationDate = default)
    {
        Random random = new();

        var randomDateOnly = new DateOnly(random.Next(2015, 2024), random.Next(1, 12), random.Next(0, 27));

        var boxDto = new CreateBoxRequest
        {
            PalletId = palletId == default
                ? Guid.NewGuid()
                : palletId,
            Length = random.Next(minLength, maxLength),
            Height = random.Next(minHeight, maxHeight),
            Width = random.Next(minWidth, maxWidth),
            Weight = random.Next(minWeight, maxWeight),
            ManufacturingDate = manufacturingDate == default
                ? randomDateOnly
                : manufacturingDate,
            ExpirationDate = expirationDate == default
                ? randomDateOnly.AddDays(random.Next(1, 1000))
                : expirationDate
        };

        return boxDto;
    }
}
