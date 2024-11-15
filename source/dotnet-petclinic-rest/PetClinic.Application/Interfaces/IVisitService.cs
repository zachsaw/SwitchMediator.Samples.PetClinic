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

    public interface IVisitService : IDisposable
    {
        Task<VisitDTO> GetVisit(int visitId, CancellationToken cancellationToken = default);
        Task AddVisit(VisitCreateDTO dto, CancellationToken cancellationToken = default);
        Task UpdateVisit(int visitId, VisitUpdateDTO dto, CancellationToken cancellationToken = default);
        Task DeleteVisit(int visitId, CancellationToken cancellationToken = default);

    }
}