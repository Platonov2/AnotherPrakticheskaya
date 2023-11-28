using Api.Controllers.Pallets.RequiestDtos;

namespace UnitTests.Controllers.Pallet;

public static partial class DataGenerator
{
    public static CreatePalletDto GenerateCreatePalletDto(
        int minLength = 1,
        int maxLength = 1,
        int minHeight = 1,
        int maxHeight = 1,
        int minWidth = 1,
        int maxWidth = 1,
        int minWeight = 1,
        int maxWeight = 1)
    {
        Random random = new();

        var palletDto = new CreatePalletDto
        {
            Length = random.Next(minLength, maxLength),
            Height = random.Next(minHeight, maxHeight),
            Width = random.Next(minWidth, maxWidth),
            Weight = random.Next(minWeight, maxWeight)
        };

        return palletDto;
    }
}
