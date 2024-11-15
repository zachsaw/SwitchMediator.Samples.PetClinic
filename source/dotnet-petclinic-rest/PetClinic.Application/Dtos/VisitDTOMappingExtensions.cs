using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using AutoMapper;
using Intent.RoslynWeaver.Attributes;
using PetClinic.Domain.Entities;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.Dtos.AutoMapper.MappingExtensions", Version = "1.0")]

namespace PetClinic.Application.Dtos
{
    public static class VisitDTOMappingExtensions
    {
        public static VisitDTO MapToVisitDTO(this Visit projectFrom, IMapper mapper)
            => mapper.Map<VisitDTO>(projectFrom);

        public static List<VisitDTO> MapToVisitDTOList(this IEnumerable<Visit> projectFrom, IMapper mapper)
            => projectFrom.Select(x => x.MapToVisitDTO(mapper)).ToList();
    }
}