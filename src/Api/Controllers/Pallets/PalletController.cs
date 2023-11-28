using Api.Controllers.Pallets.RequiestDtos;
using Api.Controllers.Pallets.ResponceDtos;
using Api.Controllers.Pallets.Validators;
using AutoMapper;
using Business.Models;
using Business.Services.Pallet;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Pallets;

[ApiController]
[Route("api/pallets")]
public class PalletController : ControllerBase
{
    private readonly IPalletService palletService;
    private readonly AbstractValidator<CreatePalletDto> createPalletValidator;
    private readonly AbstractValidator<UpdatePalletDto> updatePalletValidator;
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

    [HttpGet(Name = "GetAllPallets")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<GetPalletResponceDto>))]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        var pallets = await palletService.GetAllAsync(cancellationToken).ConfigureAwait(false);

        return Ok(mapper.Map<List<GetPalletResponceDto>>(pallets));
    }

    [HttpGet("{palletId}", Name = "GetPallet")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GetPalletResponceDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Get(Guid palletId, CancellationToken cancellationToken)
    {
        var pallet = await palletService.GetAsync(palletId, cancellationToken).ConfigureAwait(false);

        if (pallet == null)
        {
            return NotFound("Запись с данным Id не найдена");
        }

        return Ok(mapper.Map<GetPalletResponceDto>(pallet));
    }

    [HttpPost(Name = "CreatePallet")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Create(CreatePalletDto palletDto, CancellationToken cancellationToken)
    {
        var validationResult = createPalletValidator.Validate(palletDto);
        if (validationResult.Errors.Count != 0)
        {
            return BadRequest(validationResult);
        }

        var domainPallet = mapper.Map<PalletDomain>(palletDto);

        return Ok(await palletService.CreateAsync(domainPallet, cancellationToken));
    }

    [HttpPut(Name = "UpdatePallet")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Update(UpdatePalletDto palletDto, CancellationToken cancellationToken)
    {
        var validationResult = updatePalletValidator.Validate(palletDto);
        if (validationResult.Errors.Count != 0)
        {
            return BadRequest(validationResult);
        }

        var domainPallet = mapper.Map<PalletDomain>(palletDto);

        var isUpdated = await palletService.UpdateAsync(domainPallet, cancellationToken).ConfigureAwait(false);

        if (!isUpdated)
        {
            return NotFound("Запись с данным Id не найдена");
        }

        return Ok();
    }

    [HttpDelete(Name = "DeletePallet")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
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
            return BadRequest("Перед удалением паллеты необходимо убрать коробки с неё");
        }

        await palletService.DeleteAsync(palletId, cancellationToken).ConfigureAwait(false);

        return Ok();
    }

    [HttpGet("with-pagination", Name = "GetPalletsWithPagination")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<GetPalletResponceDto>))]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
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

        return Ok(mapper.Map<List<GetPalletResponceDto>>(pallets));
    }
}
