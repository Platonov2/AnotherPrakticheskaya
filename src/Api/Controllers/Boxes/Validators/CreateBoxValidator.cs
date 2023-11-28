using Api.Controllers.Boxes.RequestDtos;
using FluentValidation;

namespace Api.Controllers.Boxes.Validators;

public class CreateBoxValidator : AbstractValidator<CreateBoxDto>
{
    public CreateBoxValidator()
    {
        RuleFor(x => x.Length).NotEmpty().GreaterThan(0);
        RuleFor(x => x.Width).NotEmpty().GreaterThan(0);
        RuleFor(x => x.Height).NotEmpty().GreaterThan(0);
        RuleFor(x => x.Weight).NotEmpty().GreaterThan(0);
        RuleFor(x => x.PalletId).NotEmpty();
        RuleFor(x => x.ManufacturingDate).NotEmpty();
        RuleFor(x => x.ExpirationDate).GreaterThan(x => x.ManufacturingDate);
    }
}
