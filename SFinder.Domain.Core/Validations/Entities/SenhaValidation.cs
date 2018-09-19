using FluentValidation;
using SFinder.Domain.Core.ValueObjects;

namespace SFinder.Domain.Core.Validations.Entities
{
    public class SenhaValidation : AbstractValidator<Senha>
    {
        public SenhaValidation()
        {
            RuleFor(c => c.Valor)
              .NotNull()
              .MinimumLength(8)
              .NotEmpty();
        }
    }
}
