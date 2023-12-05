using FluentValidation;
using Avaliacoes.Domain.Entities;

namespace Avaliacoes.Service.Validators
{
    public class AvaliacaoValidator : AbstractValidator<Avaliacao>
    {
        public AvaliacaoValidator()
        {
            RuleFor(c => c.Nota)
                .NotEmpty().WithMessage("Por favor informe a nota.")
                .NotNull().WithMessage("Por favor informe a nota.");
            RuleFor(c => c.Avaliacao2)
                .NotEmpty().WithMessage("Por favor escreva a avaliação.")
                .NotNull().WithMessage("Por favor escreva a avaliação.");
            RuleFor(c => c.DataAvaliacao)
                .NotEmpty().WithMessage("Por favor informe a data.")
                .NotNull().WithMessage("Por favor informe a data.");
        }
    }
}