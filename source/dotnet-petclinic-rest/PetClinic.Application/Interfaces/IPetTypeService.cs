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

    public interface IPetTypeService : IDisposable
    {
        Task<List<PetTypeDTO>> GetAllPetTypes(CancellationToken cancellationToken = default);
        Task<PetTypeDTO> GetPetType(int petTypeId, CancellationToken cancellationToken = default);
        Task<int> AddPetType(PetTypeDTO dto, CancellationToken cancellationToken = default);
        Task UpdatePetType(int petTypeId, PetTypeDTO dto, CancellationToken cancellationToken = default);
        Task DeletePetType(int petTypeId, CancellationToken cancellationToken = default);

    }
}