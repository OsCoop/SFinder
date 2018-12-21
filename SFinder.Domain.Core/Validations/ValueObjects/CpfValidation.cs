using FluentValidation;
using SFinder.Domain.Core.ValueObjects;
using System.Text.RegularExpressions;

namespace SFinder.Domain.Core.Validations.ValueObjects
{
    public class CpfValidation : AbstractValidator<Cpf>
    {
        public CpfValidation()
        {
            RuleFor(c => c.Documento)
               .NotNull()
               .NotEmpty()
               .Matches(new Regex(@"[0-9]{3}\.?[0-9]{3}\.?[0-9]{3}\-?[0-9]{2}"));
        }
    }
}
