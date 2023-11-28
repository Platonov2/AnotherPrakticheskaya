using Api.Controllers.Boxes.Requests;
using Api.Controllers.Boxes.Responces;
using Api.Controllers.Boxes.Validators;
using AutoMapper;
using Business.Models;
using Business.Services.Box;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Boxes;

[ApiController]
[Route("api/boxes")]
public class BoxController : ControllerBase
{
    private readonly IBoxService boxService;
    private readonly AbstractValidator<CreateBoxRequest> createBoxValidator;
    private readonly AbstractValidator<UpdateBoxRequest> updateBoxValidator;
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

    /// <summary>
    /// Получение всех коробок
    /// </summary>
    [HttpGet(Name = "GetAllBoxes")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<GetBoxResponce>))]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        var boxes = await boxService.GetAllAsync(cancellationToken).ConfigureAwait(false);

        return Ok(mapper.Map<List<GetBoxResponce>>(boxes));
    }

    /// <summary>
    /// Получение коробки по Id
    /// </summary>
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

    /// <summary>
    /// Создание коробки
    /// </summary>
    [HttpPost(Name = "CreateBox")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ValidationResult))]
    public async Task<IActionResult> Create(CreateBoxRequest boxDto, CancellationToken cancellationToken)
    {
        var validationResult = createBoxValidator.Validate(boxDto);
        if (validationResult.Errors.Count != 0)
        {
            return BadRequest(validationResult);
        }

        var box = mapper.Map<Box>(boxDto);
        var newBoxId = await boxService.CreateAsync(box, cancellationToken);
        if (newBoxId == null)
        {
            return NotFound();
        }

        return Ok();
    }

    /// <summary>
    /// Обновление коробки по её Id
    /// </summary>
    [HttpPut(Name = "UpdateBox")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ValidationResult))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Update(UpdateBoxRequest boxDto, CancellationToken cancellationToken)
    {
        var validationResult = updateBoxValidator.Validate(boxDto);
        if (validationResult.Errors.Count != 0)
        {
            return BadRequest(validationResult);
        }

        var box = mapper.Map<Box>(boxDto);
        var isUpdated = await boxService.UpdateAsync(box, cancellationToken).ConfigureAwait(false);
        if (!isUpdated)
        {
            return NotFound("Запись с данным Id не найдена");
        }

        return Ok();
    }

    /// <summary>
    /// Удаление коробки по её Id
    /// </summary>
    [HttpDelete(Name = "DeleteBox")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> Delete(Guid boxId, CancellationToken cancellationToken)
    {
        await boxService.DeleteAsync(boxId, cancellationToken).ConfigureAwait(false);

        return Ok();
    }
}
