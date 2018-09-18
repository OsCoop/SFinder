using FluentValidation.Results;
using SFinder.Domain.Core.Interfaces.Validations;

namespace SFinder.Domain.Core.Validations
{
    public abstract class Validate : IValidate
    {
        public ValidationResult ValidationResult { get; set; }
        public abstract bool IsValid();
    }
}
