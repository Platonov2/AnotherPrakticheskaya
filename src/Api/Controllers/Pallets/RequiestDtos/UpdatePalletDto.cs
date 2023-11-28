namespace Api.Controllers.Pallets.RequiestDtos;

public class UpdatePalletDto
{
    public Guid Id { get; set; }

    public int? Length { get; set; }

    public int? Width { get; set; }

    public int? Height { get; set; }

    public int? Weight { get; set; }
}
