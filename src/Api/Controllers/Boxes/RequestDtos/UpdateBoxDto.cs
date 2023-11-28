namespace Api.Controllers.Boxes.RequestDtos;

public class UpdateBoxDto
{

    /// <summary>
    /// ИД коробки
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Длина коробки
    /// </summary>
    public int? Length { get; set; }

    /// <summary>
    /// Ширина коробки
    /// </summary>
    public int? Width { get; set; }

    /// <summary>
    /// Высота коробки
    /// </summary>
    public int? Height { get; set; }

    /// <summary>
    /// Вес коробки
    /// </summary>
    public int? Weight { get; set; }

    /// <summary>
    /// Объём коробки
    /// </summary>
    public int? Volume { get; set; }

    /// <summary>
    /// Дата производства
    /// </summary>
    public DateOnly? ManufacturingDate { get; set; }

    /// <summary>
    /// Срок годности коробки
    /// </summary>
    public DateOnly? ExpirationDate { get; set; }
}
