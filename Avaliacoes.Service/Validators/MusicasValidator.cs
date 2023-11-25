using FluentValidation;
using Avaliacoes.Domain.Entities;

namespace Avaliacoes.Service.Validators
{
    public class MusicasValidator : AbstractValidator<Musicas>
    {
        public MusicasValidator()
        {
            RuleFor(c => c.Artista)
                .NotEmpty().WithMessage("Por favor informe o artista.")
                .NotNull().WithMessage("Por favor informe o artista.");
            RuleFor(c => c.Duracao)
                .NotEmpty().WithMessage("Por favor informe a duração.")
                .NotNull().WithMessage("Por favor informe a duração.");
        }
    }
}
