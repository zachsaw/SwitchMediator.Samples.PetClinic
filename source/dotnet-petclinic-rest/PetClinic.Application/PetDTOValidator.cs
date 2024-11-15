using System;
using FluentValidation;
using Intent.RoslynWeaver.Attributes;
using PetClinic.Application.Dtos;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.FluentValidation.Dtos.DTOValidator", Version = "1.0")]

namespace PetClinic.Application
{
    [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
    public class PetDTOValidator : AbstractValidator<PetDTO>
    {
        [IntentManaged(Mode.Fully, Body = Mode.Ignore, Signature = Mode.Merge)]
        public PetDTOValidator()
        {
            ConfigureValidationRules();
        }

        [IntentManaged(Mode.Fully)]
        private void ConfigureValidationRules()
        {
            RuleFor(v => v.Name)
                .NotNull()
                .MaximumLength(30);

            RuleFor(v => v.PetTypeName)
                .NotNull()
                .MaximumLength(80);

            RuleFor(v => v.OwnerFirstName)
                .NotNull()
                .MaximumLength(30);

            RuleFor(v => v.OwnerLastName)
                .NotNull()
                .MaximumLength(30);

            RuleFor(v => v.Visits)
                .NotNull();
        }
    }
}