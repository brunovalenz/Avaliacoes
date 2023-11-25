﻿using FluentValidation;
using Avaliacoes.Domain.Entities;

namespace Avaliacoes.Service.Validators
{
    public class SeriesValidator : AbstractValidator<Series>
    {
        public SeriesValidator()
        {
            RuleFor(c => c.Diretor)
                .NotEmpty().WithMessage("Por favor informe o diretor.")
                .NotNull().WithMessage("Por favor informe o diretor.");
            RuleFor(c => c.QntEps)
                .NotEmpty().WithMessage("Por favor informe a quantidade de episódios.")
                .NotNull().WithMessage("Por favor informe a quantidade de episódios.");
        }
    }
}
