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

    public interface IOwnerService : IDisposable
    {
        Task<List<OwnerDTO>> GetOwners(CancellationToken cancellationToken = default);
        Task AddOwner(OwnerCreateDTO dto, CancellationToken cancellationToken = default);
        Task<OwnerDTO> GetOwner(int ownerId, CancellationToken cancellationToken = default);
        Task UpdateOwner(int ownerId, OwnerUpdateDTO dto, CancellationToken cancellationToken = default);
        Task DeleteOwner(int ownerId, CancellationToken cancellationToken = default);
        Task<List<OwnerDTO>> GetOwnersList(string lastName, CancellationToken cancellationToken = default);

    }
}