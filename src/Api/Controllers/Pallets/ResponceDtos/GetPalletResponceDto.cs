using Business.Models;
using Storage.Entities;
using System.ComponentModel.DataAnnotations;

namespace Api.Controllers.Pallets.ResponceDtos;

internal sealed class GetPalletResponceDto
{

    public GetPalletResponceDto() { }

    /// <summary>
    /// ИД палетты
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Длина палетты
    /// </summary>
    public int Length { get; set; }

    /// <summary>
    /// Ширина палетты
    /// </summary>
    public int Width { get; set; }

    /// <summary>
    /// Высота палетты
    /// </summary>
    public int Height { get; set; }

    /// <summary>
    /// Собственный вес палетты
    /// </summary>
    public int Weight { get; set; }

    /// <summary>
    /// Суммарный вес палетты с учётом коробок
    /// </summary>
    public int TotalWeight { get; set; }

    /// <summary>
    /// Суммарный объём палетты с учётом коробок
    /// </summary>
    public int TotalVolume { get; set; }

    /// <summary>
    /// Коробки на палетте
    /// </summary>
    public List<BoxDomain> Boxes { get; set; } = new();

    /// <summary>
    /// Срок годности палетты
    /// </summary>
    public DateOnly? ExpirationDate { get; set; }
}
