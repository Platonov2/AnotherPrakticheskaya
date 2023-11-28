using Storage.Entities;
using System.ComponentModel.DataAnnotations;

namespace Business.Models;

public sealed class PalletDomain
{
    private int length;
    private int width;
    private int height;
    private int weight;

    public PalletDomain() { }

    public PalletDomain(Guid id, int length, int width, int height, int weight) :
        this(id, length, width, height, weight, null)
    {
    }

    public PalletDomain(Guid id, int length, int width, int height, int weight, List<Box>? boxes)
    {
        Id = id;
        Length = length;
        Width = width;
        Height = height;
        Weight = weight;

        boxes?.ForEach(box => AddBox(box));
    }

    /// <summary>
    /// Добовление коробки в палетту
    /// </summary>
    public void AddBox(Box box)
    {
        if (box.Length > Length || box.Width > Width)
        {
            throw new ArgumentOutOfRangeException("Размеры коробки больше размеров паллеты "
                + box.Length.ToString() + " " + box.Width.ToString() + " " + Length.ToString() + " " + Width.ToString());
        }

        box.PalletId = Id;
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
    public List<BoxDomain> Boxes { get; set; } = new();

    /// <summary>
    /// Срок годности палетты
    /// </summary>
    public DateOnly? ExpirationDate =>
        Boxes.Count != 0
        ? Boxes.Min(b => b.ExpirationDate)
        : null;
}
