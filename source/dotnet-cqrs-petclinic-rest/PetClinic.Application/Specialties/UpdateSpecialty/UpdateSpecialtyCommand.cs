using System;
using System.Collections.Generic;
using Intent.RoslynWeaver.Attributes;
using Mediator.Switch;
using PetClinic.Application.Common.Interfaces;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.CommandModels", Version = "1.0")]

namespace PetClinic.Application.Specialties.UpdateSpecialty
{
    public class UpdateSpecialtyCommand : IRequest<Unit>, ICommand
    {
        public UpdateSpecialtyCommand(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public int Id { get; set; }

        public string Name { get; set; }

    }
}