using Storage.Entities;

namespace Business.Models;

/// <summary>
/// Внутренняя модель паллеты
/// </summary>
public sealed class Pallet
{
    public Pallet() { }

    /// <summary>
    /// Добовление коробки в палетту
    /// </summary>
    public void AddBox(BoxRecord box)
    {
        if (box.Length > Length || box.Width > Width)
        {
            throw new ArgumentOutOfRangeException("Размеры коробки больше размеров паллеты "
                + box.Length.ToString() + " " + box.Width.ToString() + " " + Length.ToString() + " " + Width.ToString());
        }

        box.PalletRecordId = Id;
    }

    /// <summary>
    /// ИД палетты
    /// </summary>
    public Guid Id { get; private set; }

    /// <summary>
    /// Длина палетты
    /// </summary>
    public int? Length { get; set; }

    /// <summary>
    /// Ширина палетты
    /// </summary>
    public int? Width { get; set; }

    /// <summary>
    /// Высота палетты
    /// </summary>
    public int? Height { get; set; }

    /// <summary>
    /// Собственный вес палетты
    /// </summary>
    public int? Weight { get; set; }

    /// <summary>
    /// Суммарный вес палетты с учётом коробок
    /// </summary>
    public int? TotalWeight => Weight + Boxes.Sum(b => b.Weight);

    /// <summary>
    /// Суммарный объём палетты с учётом коробок
    /// </summary>
    public int? TotalVolume => (Width * Length * Height) + Boxes.Sum(b => b.Volume);

    /// <summary>
    /// Коробки на палетте
    /// </summary>
    public List<Box> Boxes { get; set; } = new();

    /// <summary>
    /// Срок годности палетты
    /// </summary>
    public DateOnly? ExpirationDate =>
        Boxes.Count != 0
        ? Boxes.Min(b => b.ExpirationDate)
        : null;
}
