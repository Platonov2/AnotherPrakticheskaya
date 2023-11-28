using Api.Controllers.Boxes.RequestDtos;
using FluentValidation;

namespace Api.Controllers.Boxes.Validators;

public class UpdateBoxValidator : AbstractValidator<UpdateBoxDto>
{
    public UpdateBoxValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
        RuleFor(x => x.Length).GreaterThan(0);
        RuleFor(x => x.Width).GreaterThan(0);
        RuleFor(x => x.Height).GreaterThan(0);
        RuleFor(x => x.Weight).GreaterThan(0);
        RuleFor(x => x.ManufacturingDate);
        RuleFor(x => x.ExpirationDate).GreaterThan(x => x.ManufacturingDate);
    }
}
