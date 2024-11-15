using System;
using FluentValidation;
using Intent.RoslynWeaver.Attributes;
using PetClinic.Application.Dtos;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.FluentValidation.Dtos.DTOValidator", Version = "1.0")]

namespace PetClinic.Application
{
    [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
    public class VisitDTOValidator : AbstractValidator<VisitDTO>
    {
        [IntentManaged(Mode.Fully, Body = Mode.Ignore, Signature = Mode.Merge)]
        public VisitDTOValidator()
        {
            ConfigureValidationRules();
        }

        [IntentManaged(Mode.Fully)]
        private void ConfigureValidationRules()
        {
            RuleFor(v => v.Description)
                .NotNull();

            RuleFor(v => v.Pet)
                .NotNull();
        }
    }
}