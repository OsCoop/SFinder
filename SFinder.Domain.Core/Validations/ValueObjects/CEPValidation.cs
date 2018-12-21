using FluentValidation;
using SFinder.Domain.Core.ValueObjects;
using System.Text.RegularExpressions;

namespace SFinder.Domain.Core.Validations.ValueObjects
{
    public class CepValidation : AbstractValidator<Cep>
    {
        public CepValidation()
        {
            RuleFor(c => c.Valor)
           .NotNull()
           .NotEmpty()
           .Length(9)
           .Matches(new Regex(@"^\\d{5}[-]\\d{3}$"));
        }
    }
}
