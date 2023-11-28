using Api.Controllers.Pallets.RequiestDtos;
using FluentValidation;

namespace Api.Controllers.Pallets.Validators;

public class UpdatePalletValidator : AbstractValidator<UpdatePalletDto>
{
    public UpdatePalletValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
        RuleFor(x => x.Length).GreaterThan(0);
        RuleFor(x => x.Height).GreaterThan(0);
        RuleFor(x => x.Width).GreaterThan(0);
        RuleFor(x => x.Weight).GreaterThan(0);
    }
}
