using SFinder.Domain.Core.Validations;
using SFinder.Domain.Core.Validations.ValueObjects;

namespace SFinder.Domain.Core.ValueObjects
{
    public class Email : Validate
    {
        public string Endereco { get; private set; }

        public Email(string email)
        {
            Endereco = email;
            ValidationResult = new EmailValidation().Validate(this);
        }

        public override string ToString()
        {
            return Endereco;
        }
    }
}
