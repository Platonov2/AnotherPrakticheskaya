namespace Storage.Entities;

/// <summary>
/// Модель записи коробки в БД
/// </summary>
public sealed class BoxRecord
{
    private int length;
    private int width;
    private int height;
    private int weight;
    private DateOnly manufacturingDate;
    private DateOnly expirationDate;

    public BoxRecord() { }

    public BoxRecord(Guid id, int length, int width, int height, int weight, DateOnly manufacturingDate)
        : this(id, length, width, height, weight, manufacturingDate, new DateOnly())
    {
    }

    public BoxRecord(Guid id, int length, int width, int height, int weight, DateOnly manufacturingDate, DateOnly expirationDate)
    {
        Id = id;
        Length = length;
        Width = width;
        Height = height;
        Weight = weight;
        ManufacturingDate = manufacturingDate;
        ExpirationDate = expirationDate;
    }

    /// <summary>
    /// ИД коробки
    /// </summary>
    public Guid Id { get; private set; }

    /// <summary>
    /// Внешний ключ Id паллеты
    /// </summary>
    public Guid PalletRecordId { get; set; }

    /// <summary>
    /// Длина коробки
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
    /// Ширина коробки
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
    /// Высота коробки
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
    /// Вес коробки
    /// </summary>
    public int Weight
    {
        get => weight;
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("weight = " + value.ToString());
            }

            weight = value;
        }
    } 

    /// <summary>
    /// Дата производства
    /// </summary>
    public DateOnly ManufacturingDate { get => manufacturingDate; private set => manufacturingDate = value; }

    /// <summary>
    /// Срок годности коробки
    /// </summary>
    public DateOnly ExpirationDate
    {
        get => expirationDate;
        private set
        {
            if (expirationDate < manufacturingDate)
            {
                throw new ArgumentOutOfRangeException("manufacturingDate > expirationDate " + value.ToString());
            }
        }
    }
}
