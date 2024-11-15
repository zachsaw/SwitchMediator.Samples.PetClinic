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

    public interface IVetService : IDisposable
    {
        Task<List<VetDTO>> GetAllVets(CancellationToken cancellationToken = default);
        Task<VetDTO> GetVet(int vetId, CancellationToken cancellationToken = default);
        Task AddVet(VetCreateDTO dto, CancellationToken cancellationToken = default);
        Task UpdateVet(int vetId, VetUpdateDTO dto, CancellationToken cancellationToken = default);
        Task DeleteVet(int vetId, CancellationToken cancellationToken = default);

    }
}