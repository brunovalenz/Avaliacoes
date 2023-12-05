using FluentValidation;
using Avaliacoes.Domain.Entities;

namespace Avaliacoes.Service.Validators
{
    public class MidiaValidator : AbstractValidator<Midia>
    {
        public MidiaValidator()
        {
            RuleFor(c => c.Titulo)
                .NotEmpty().WithMessage("Por favor informe o titulo.")
                .NotNull().WithMessage("Por favor informe o titulo.");
            RuleFor(c => c.AnoLancamento)
                .NotEmpty().WithMessage("Por favor informe o ano de lançamento.")
                .NotNull().WithMessage("Por favor informe o ano de lançamento.");
            RuleFor(c => c.Descricao)
                .NotEmpty().WithMessage("Por favor informe a descrição.")
                .NotNull().WithMessage("Por favor informe a descrição.");
            RuleFor(c => c.Classificacao)
                .NotEmpty().WithMessage("Por favor informe a classificação.")
                .NotNull().WithMessage("Por favor informe a classificação.");
        }
    }
}