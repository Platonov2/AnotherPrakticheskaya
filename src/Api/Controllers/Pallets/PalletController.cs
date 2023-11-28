using Api.Controllers.Pallets.Requests;
using Api.Controllers.Pallets.Responces;
using Api.Controllers.Pallets.Validators;
using AutoMapper;
using Business.Models;
using Business.Services.Pallet;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Pallets;

[ApiController]
[Route("api/pallets")]
public class PalletController : ControllerBase
{
    private readonly IPalletService palletService;
    private readonly AbstractValidator<CreatePalletRequest> createPalletValidator;
    private readonly AbstractValidator<UpdatePalletRequest> updatePalletValidator;
    private readonly IMapper mapper;

    public PalletController(
        IPalletService palletService,
        CreatePalletValidator createPalletValidator,
        UpdatePalletValidator updatePalletValidator,
        IMapper mapper)
    {
        this.palletService = palletService;
        this.createPalletValidator = createPalletValidator;
        this.updatePalletValidator = updatePalletValidator;
        this.mapper = mapper;
    }

    /// <summary>
    /// Получение всех паллет
    /// </summary>
    [HttpGet(Name = "GetAllPallets")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<GetPalletResponce>))]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        var pallets = await palletService.GetAllAsync(cancellationToken).ConfigureAwait(false);

        return Ok(mapper.Map<List<GetPalletResponce>>(pallets));
    }

    /// <summary>
    /// Получение паллеты по Id
    /// </summary>
    [HttpGet("{palletId}", Name = "GetPallet")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GetPalletResponce))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Get(Guid palletId, CancellationToken cancellationToken)
    {
        var pallet = await palletService.GetAsync(palletId, cancellationToken).ConfigureAwait(false);
        if (pallet == null)
        {
            return NotFound("Запись с данным Id не найдена");
        }

        return Ok(mapper.Map<GetPalletResponce>(pallet));
    }

    /// <summary>
    /// Создание паллеты
    /// </summary>
    [HttpPost(Name = "CreatePallet")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ValidationResult))]
    public async Task<IActionResult> Create(CreatePalletRequest palletDto, CancellationToken cancellationToken)
    {
        var validationResult = createPalletValidator.Validate(palletDto);
        if (validationResult.Errors.Count != 0)
        {
            return BadRequest(validationResult);
        }

        var domainPallet = mapper.Map<Pallet>(palletDto);

        return Ok(await palletService.CreateAsync(domainPallet, cancellationToken));
    }

    /// <summary>
    /// Обновление паллеты
    /// </summary>
    [HttpPut(Name = "UpdatePallet")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Update(UpdatePalletRequest palletDto, CancellationToken cancellationToken)
    {
        var validationResult = updatePalletValidator.Validate(palletDto);
        if (validationResult.Errors.Count != 0)
        {
            return BadRequest(validationResult);
        }

        var domainPallet = mapper.Map<Pallet>(palletDto);
        var isUpdated = await palletService.UpdateAsync(domainPallet, cancellationToken).ConfigureAwait(false);
        if (!isUpdated)
        {
            return NotFound("Запись с данным Id не найдена");
        }

        return Ok();
    }

    /// <summary>
    /// Удаление паллеты
    /// </summary>
    [HttpDelete(Name = "DeletePallet")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ValidationResult))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(Guid palletId, CancellationToken cancellationToken)
    {
        var pallet = await palletService.GetAsync(palletId, cancellationToken).ConfigureAwait(false);
        if (pallet == null)
        {
            return NotFound("Запись с данным Id не найдена");
        }

        if (pallet.Boxes.Count != 0)
        {
            return BadRequest("Перед удалением паллеты необходимо убрать с неё коробки");
        }

        await palletService.DeleteAsync(palletId, cancellationToken).ConfigureAwait(false);

        return Ok();
    }

    /// <summary>
    /// Получение паллет с паггинацией
    /// </summary>
    [HttpGet("with-pagination", Name = "GetPalletsWithPagination")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<GetPalletResponce>))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ValidationResult))]
    public async Task<IActionResult> GetWithPagination(
        int offset,
        int take,
        CancellationToken cancellationToken)
    {
        if (offset < 0 || take < 0)
        {
            return BadRequest($"Offset и Take должны быть положительными");
        }

        var pallets = await palletService.GetWithPaginationAsync(offset, take, cancellationToken)
            .ConfigureAwait(false);

        return Ok(mapper.Map<List<GetPalletResponce>>(pallets));
    }
}
