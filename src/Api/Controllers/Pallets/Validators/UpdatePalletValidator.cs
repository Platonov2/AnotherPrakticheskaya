using Api.Controllers.Pallets.Requests;
using FluentValidation;

namespace Api.Controllers.Pallets.Validators;

public class UpdatePalletValidator : AbstractValidator<UpdatePalletRequest>
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
