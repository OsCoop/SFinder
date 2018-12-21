using SFinder.Domain.Core.Validations;
using SFinder.Domain.Core.Validations.ValueObjects;

namespace SFinder.Domain.Core.ValueObjects
{
    public class Cep : Validate
    {
        public string Valor { get; private set; }

        public Cep(string valor)
        {
            Valor = valor;
            ValidationResult = new CepValidation().Validate(this);
        }

        public override string ToString()
        {
            return Valor;
        }
    }
}
