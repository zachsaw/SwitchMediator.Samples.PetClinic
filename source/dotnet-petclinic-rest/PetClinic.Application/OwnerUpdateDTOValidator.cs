using System;
using FluentValidation;
using Intent.RoslynWeaver.Attributes;
using PetClinic.Application.Dtos;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.FluentValidation.Dtos.DTOValidator", Version = "1.0")]

namespace PetClinic.Application
{
    [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
    public class OwnerUpdateDTOValidator : AbstractValidator<OwnerUpdateDTO>
    {
        [IntentManaged(Mode.Fully, Body = Mode.Ignore, Signature = Mode.Merge)]
        public OwnerUpdateDTOValidator()
        {
            ConfigureValidationRules();
        }

        [IntentManaged(Mode.Fully)]
        private void ConfigureValidationRules()
        {
            RuleFor(v => v.FirstName)
                .NotNull();

            RuleFor(v => v.LastName)
                .NotNull();

            RuleFor(v => v.Address)
                .NotNull();

            RuleFor(v => v.City)
                .NotNull();

            RuleFor(v => v.Telephone)
                .NotNull();
        }
    }
}