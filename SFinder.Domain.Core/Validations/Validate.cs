using FluentValidation.Results;
using SFinder.Domain.Core.Interfaces.Validations;

namespace SFinder.Domain.Core.Validations
{
    public abstract class Validate : IValidate
    {
        public ValidationResult ValidationResult { get; set; }
        /// <summary>
        /// Usado para validar quando não precisa de override
        /// </summary>
        /// <returns></returns>
        public virtual bool IsValid()
        {
            return ValidationResult?.IsValid ?? false;
        }
    }
}
