using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Intent.RoslynWeaver.Attributes;
using PetClinic.Application.Dtos;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.Contracts.ServiceContract", Version = "1.0")]

namespace PetClinic.Application.Interfaces
{

    public interface IPetService : IDisposable
    {
        Task<PetDTO> GetPet(int petId, CancellationToken cancellationToken = default);
        Task AddPet(PetCreateDTO dto, CancellationToken cancellationToken = default);
        Task UpdatePet(int petId, PetUpdateDTO dto, CancellationToken cancellationToken = default);
        Task DeletePet(int petId, CancellationToken cancellationToken = default);

    }
}