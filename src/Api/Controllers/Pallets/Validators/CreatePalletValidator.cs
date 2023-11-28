﻿using Api.Controllers.Pallets.RequiestDtos;
using FluentValidation;

namespace Api.Controllers.Pallets.Validators;

public class CreatePalletValidator : AbstractValidator<CreatePalletDto>
{
    public CreatePalletValidator()
    {
        RuleFor(x => x.Length).NotEmpty().GreaterThan(0);
        RuleFor(x => x.Height).NotEmpty().GreaterThan(0);
        RuleFor(x => x.Width).NotEmpty().GreaterThan(0);
        RuleFor(x => x.Weight).NotEmpty().GreaterThan(0);
    }
}
