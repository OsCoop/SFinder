using SFinder.Domain.Core.Events;
using SFinder.Domain.Core.Interfaces.Validations;
using System;
using FluentValidation.Results;

namespace SFinder.Domain.Core.Commands
{
    public abstract class Command : Message, IValidate
    {
        public DateTime Timestamp { get; private set; }
        public ValidationResult ValidationResult { get; set; }

        protected Command()
        {
            Timestamp = DateTime.Now;
        }

        public abstract bool IsValid();
    }
}
