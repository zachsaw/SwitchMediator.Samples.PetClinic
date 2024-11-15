using System;
using System.Collections.Generic;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.Dtos.DtoModel", Version = "1.0")]

namespace PetClinic.Application.Dtos
{

    public class VetUpdateDTO
    {
        public VetUpdateDTO()
        {
            FirstName = null!;
            LastName = null!;
            Specialties = null!;
        }

        public static VetUpdateDTO Create(string firstName, string lastName, List<int> specialties)
        {
            return new VetUpdateDTO
            {
                FirstName = firstName,
                LastName = lastName,
                Specialties = specialties
            };
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<int> Specialties { get; set; }

    }
}