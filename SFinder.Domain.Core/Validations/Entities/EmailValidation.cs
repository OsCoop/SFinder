﻿using FluentValidation;
using SFinder.Domain.Core.ValueObjects;

namespace SFinder.Domain.Core.Validations.Entities
{
    public class EmailValidation : AbstractValidator<Email>
    {
        public EmailValidation()
        {
            RuleFor(c => c.Endereco)
               .NotNull()
               .NotEmpty()
               .EmailAddress();
        }
    }
}
