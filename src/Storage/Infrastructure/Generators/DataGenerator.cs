using Storage.Entities;

namespace Storage.Infrastructure.Generators;

internal static class DataGenerator
{
    public static (List<PalletRecord>, List<BoxRecord>) Generate()
    {
        var rnd = new Random();
        var pallets = new List<PalletRecord>();
        var boxes = new List<BoxRecord>();

        var numberOfPallets = rnd.Next(15, 30);

        for (var i = 0; i < numberOfPallets; i++)
        {
            var pallet = GeneratePallet();
            pallets.Add(pallet);

            var numberOfBoxes = rnd.Next(1, 5);
            for (var j = 0; j < numberOfBoxes; j++)
            {
                var box = GenerateBox(pallet.Length / numberOfBoxes, pallet.Width / numberOfBoxes);
                pallet.AddBox(box);
                boxes.Add(box);
            }
        }

        return (pallets, boxes);
    }

    private static PalletRecord GeneratePallet()
    {
        var rnd = new Random();

        var id = Guid.NewGuid();
        var palletLength = rnd.Next(10, 50);
        var palletWidth = rnd.Next(10, 50);
        var palletHeight = rnd.Next(10, 50);
        var palletWeight = rnd.Next(30, 50);

        return new PalletRecord(id, palletLength, palletWidth, palletHeight, palletWeight);
    }

    private static BoxRecord GenerateBox(int maxLength, int maxWidth)
    {
        var rnd = new Random();

        var id = Guid.NewGuid();
        var length = rnd.Next(1, maxLength);
        var width = rnd.Next(1, maxWidth);
        var heigth = rnd.Next(1, 10);
        var weigh = rnd.Next(1, 10);

        var manufacturingYear = rnd.Next(2015, 2024);
        var manufacturingMonth = rnd.Next(1, 13);
        var manufacturingDay = rnd.Next(1, 29);
        var manufacturingDate = new DateOnly(manufacturingYear, manufacturingMonth, manufacturingDay);

        var hasExpirationDate = rnd.Next(2);
        if (hasExpirationDate == 1)
        {
            var expirationYear = rnd.Next(manufacturingYear, 2024);
            var expirationMonth = rnd.Next(manufacturingMonth, 13);
            var expirationDay = rnd.Next(manufacturingDay, 29);
            var expirationDate = new DateOnly(expirationYear, expirationMonth, expirationDay);

            return new BoxRecord(id, length, width, heigth, weigh, manufacturingDate, expirationDate);
        }

        return new BoxRecord(id, length, width, heigth, weigh, manufacturingDate);
    }
}
