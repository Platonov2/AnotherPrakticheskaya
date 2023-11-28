namespace Api.Controllers.Pallets.Requests;

/// <summary>
/// Модель запроса на обновление паллеты
/// </summary>
public sealed class UpdatePalletRequest
{
    /// <summary>
    /// Id паллеты
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Длинна паллеты
    /// </summary>
    public int? Length { get; set; }

    /// <summary>
    /// Ширина паллеты
    /// </summary>
    public int? Width { get; set; }

    /// <summary>
    /// Высота паллеты
    /// </summary>
    public int? Height { get; set; }

    /// <summary>
    /// Вес паллеты
    /// </summary>
    public int? Weight { get; set; }
}
