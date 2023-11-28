namespace Api.Controllers.Pallets.Requests;

/// <summary>
/// Модель запроса на создание паллеты
/// </summary>
public sealed class CreatePalletRequest
{
    /// <summary>
    /// Длина паллеты
    /// </summary>
    public int Length { get; set; }

    /// <summary>
    /// Ширина паллеты
    /// </summary>
    public int Width { get; set; }

    /// <summary>
    /// Высота паллеты
    /// </summary>
    public int Height { get; set; }

    /// <summary>
    /// Вес паллеты
    /// </summary>
    public int Weight { get; set; }
}
