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

    public interface ISpecialtyService : IDisposable
    {
        Task<List<SpecialtyDTO>> GetAllSpecialties(CancellationToken cancellationToken = default);
        Task<SpecialtyDTO> GetSpecialty(int specialtyId, CancellationToken cancellationToken = default);
        Task<int> AddSpecialty(SpecialtyDTO dto, CancellationToken cancellationToken = default);
        Task UpdateSpecialty(int specialtyId, SpecialtyDTO dto, CancellationToken cancellationToken = default);
        Task DeleteSpecialty(int specialtyId, CancellationToken cancellationToken = default);

    }
}