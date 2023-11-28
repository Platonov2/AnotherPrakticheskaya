using Api.Controllers.Boxes.Requests;
using FluentValidation;

namespace Api.Controllers.Boxes.Validators;

public sealed class UpdateBoxValidator : AbstractValidator<UpdateBoxRequest>
{
    public UpdateBoxValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
        RuleFor(x => x.Length).NotEmpty().GreaterThan(0);
        RuleFor(x => x.Width).NotEmpty().GreaterThan(0);
        RuleFor(x => x.Height).NotEmpty().GreaterThan(0);
        RuleFor(x => x.Weight).NotEmpty().GreaterThan(0);
        RuleFor(x => x.ManufacturingDate).NotEmpty();
        RuleFor(x => x.ExpirationDate).GreaterThan(x => x.ManufacturingDate);
    }
}
