using FluentValidation;
using Avaliacoes.Domain.Entities;

namespace Avaliacoes.Service.Validators
{
    public class FilmeValidator : AbstractValidator<Filme>
    {
        public FilmeValidator()
        {
            RuleFor(c => c.Diretor)
                .NotEmpty().WithMessage("Por favor informe o diretor.")
                .NotNull().WithMessage("Por favor informe o diretor.");
            RuleFor(c => c.Duracao)
                .NotEmpty().WithMessage("Por favor informe a duração.")
                .NotNull().WithMessage("Por favor informe a duração.");
        }
    }
}