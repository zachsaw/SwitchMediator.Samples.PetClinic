using System;
using System.Collections.Generic;
using Intent.RoslynWeaver.Attributes;
using Mediator.Switch;
using PetClinic.Application.Common.Interfaces;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.CommandModels", Version = "1.0")]

namespace PetClinic.Application.Owners.DeleteOwner
{
    public class DeleteOwnerCommand : IRequest<Unit>, ICommand
    {
        public DeleteOwnerCommand(int id)
        {
            Id = id;
        }
        public int Id { get; set; }

    }
}