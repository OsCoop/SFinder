using SFinder.Domain.Core.Validations;
using SFinder.Domain.Core.Validations.Entities;

namespace SFinder.Domain.Core.ValueObjects
{
    public class Cpf : Validate
    {
        public string Documento { get; private set; }
        public Cpf(string cpf)
        {
            Documento = cpf;
            ValidationResult = new CpfValidation().Validate(this);
        }
        public override bool IsValid()
        {
            return ValidationResult.IsValid;
        }
        public override string ToString()
        {
            return Documento;
        }
    }
}
