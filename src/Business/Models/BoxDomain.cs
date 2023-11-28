namespace Business.Models;

public sealed class BoxDomain
{
    /// <summary>
    /// ИД коробки
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Внешний ключ Id паллеты
    /// </summary>
    public Guid PalletId { get; set; }

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
    public int? Volume => Length * Width * Height;

    /// <summary>
    /// Дата производства
    /// </summary>
    public DateOnly? ManufacturingDate { get; set; }

    /// <summary>
    /// Срок годности коробки
    /// </summary>
    public DateOnly? ExpirationDate { get; set; }
}
