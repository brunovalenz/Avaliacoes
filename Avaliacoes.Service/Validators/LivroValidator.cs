using FluentValidation;
using Avaliacoes.Domain.Entities;

namespace Avaliacoes.Service.Validators
{
    public class LivroValidator : AbstractValidator<Livro>
    {
        public LivroValidator()
        {
            RuleFor(c => c.Autor)
                .NotEmpty().WithMessage("Por favor informe o autor.")
                .NotNull().WithMessage("Por favor informe o autor.");
            RuleFor(c => c.TotalPag)
                .NotEmpty().WithMessage("Por favor informe o total de páginas.")
                .NotNull().WithMessage("Por favor informe o total de páginas.");
        }
    }
}