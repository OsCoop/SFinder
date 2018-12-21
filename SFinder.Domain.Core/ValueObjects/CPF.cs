using SFinder.Domain.Core.Validations;
using SFinder.Domain.Core.Validations.ValueObjects;

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
        
        public override string ToString()
        {
            return Documento;
        }
    }
}
