namespace Storage.Entities;

/// <summary>
/// Модель записи паллет в БД
/// </summary>
public sealed class PalletRecord
{
    private int length;
    private int width;
    private int height;
    private int weight;

    public PalletRecord() { }

    public PalletRecord(Guid id, int length, int width, int height, int weight) :
        this(id, length, width, height, weight, null)
    {
    }

    public PalletRecord(Guid id, int length, int width, int height, int weight, List<BoxRecord>? boxes)
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
    public int Length
    {
        get => length;
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("length = " + value.ToString());
            }

            length = value;
        }
    }

    /// <summary>
    /// Ширина палетты
    /// </summary>
    public int Width
    {
        get => width;
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("width = " + value.ToString());
            }

            width = value;
        }
    }

    /// <summary>
    /// Высота палетты
    /// </summary>
    public int Height
    {
        get => height;
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("height = " + value.ToString());
            }

            height = value;
        }
    }

    /// <summary>
    /// Собственный вес палетты
    /// </summary>
    public int Weight
    {
        get => weight;
        private set => weight = value <= 0 ? 30 : value;
    }

    /// <summary>
    /// Коробки на палетте
    /// </summary>
    public List<BoxRecord> Boxes { get; set; } = new();

    /// <summary>
    /// Срок годности палетты
    /// </summary>
    public DateOnly? ExpirationDate =>
        Boxes.Count != 0
        ? Boxes.Min(b => b.ExpirationDate)
        : null;
}
