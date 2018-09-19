using SFinder.Domain.Core.Validations;
using SFinder.Domain.Core.Validations.Entities;

namespace SFinder.Domain.Core.ValueObjects
{
    public class Senha : Validate
    {
        public string Valor { get; set; }
        public Senha(string senha)
        {
            Valor = senha;
            ValidationResult = new SenhaValidation().Validate(this);
        }

        public override string ToString()
        {
            return Valor;
        }

    }
}
