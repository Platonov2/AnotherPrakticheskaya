using Api.Controllers.Boxes.RequestDtos;
using Api.Controllers.Boxes.ResponceDtos;
using Api.Controllers.Boxes.Validators;
using Api.Controllers.Pallets.RequiestDtos;
using Api.Controllers.Pallets.ResponceDtos;
using Api.Controllers.Pallets.Validators;
using AutoMapper;
using Business.Models;
using Business.Services.Box;
using Business.Services.Pallet;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Boxes;

[ApiController]
[Route("api/boxes")]
public class BoxController : ControllerBase
{
    private readonly IBoxService boxService;
    private readonly AbstractValidator<CreateBoxDto> createBoxValidator;
    private readonly AbstractValidator<UpdateBoxDto> updateBoxValidator;
    private readonly IMapper mapper;

    public BoxController(
        IBoxService boxService,
        CreateBoxValidator createBoxValidator,
        UpdateBoxValidator updateBoxValidator,
        IMapper mapper)
    {
        this.boxService = boxService;
        this.createBoxValidator = createBoxValidator;
        this.updateBoxValidator = updateBoxValidator;
        this.mapper = mapper;
    }

    [HttpGet(Name = "GetAllBoxes")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<GetBoxResponce>))]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        var boxes = await boxService.GetAllAsync(cancellationToken).ConfigureAwait(false);

        return Ok(mapper.Map<List<GetBoxResponce>>(boxes));
    }

    [HttpGet("{boxId}", Name = "GetBox")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GetBoxResponce))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Get(Guid boxId, CancellationToken cancellationToken)
    {
        var box = await boxService.GetAsync(boxId, cancellationToken).ConfigureAwait(false);

        if (box == null)
        {
            return NotFound("Коробка по заданному Id не найдена");
        }

        return Ok(mapper.Map<GetBoxResponce>(box));
    }

    [HttpPost(Name = "CreateBox")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> Create(CreateBoxDto boxDto, CancellationToken cancellationToken)
    {
        var validationResult = createBoxValidator.Validate(boxDto);
        if (validationResult.Errors.Count != 0)
        {
            return BadRequest(validationResult);
        }

        var box = mapper.Map<BoxDomain>(boxDto);
        var newBoxId = await boxService.CreateAsync(box, cancellationToken);

        if (newBoxId == null)
        {
            return NotFound();
        }

        return Ok();
    }

    [HttpPut(Name = "UpdateBox")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Update(UpdateBoxDto boxDto, CancellationToken cancellationToken)
    {
        var validationResult = updateBoxValidator.Validate(boxDto);
        if (validationResult.Errors.Count != 0)
        {
            return BadRequest(validationResult);
        }

        var box = mapper.Map<BoxDomain>(boxDto);
        var isUpdated = await boxService.UpdateAsync(box, cancellationToken).ConfigureAwait(false);

        if (!isUpdated)
        {
            return NotFound("Запись с данным Id не найдена");
        }

        return Ok();
    }

    [HttpDelete(Name = "DeleteBox")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(Guid boxId, CancellationToken cancellationToken)
    {
        var isDeleted = await boxService.DeleteAsync(boxId, cancellationToken).ConfigureAwait(false);

        if (!isDeleted)
        {
            return NotFound("Запись с данным Id не найдена");
        }

        return Ok();
    }
}
