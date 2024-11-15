using Intent.RoslynWeaver.Attributes;

[assembly: IntentTagModeImplicit]
[assembly: IntentTemplate("Intent.Entities.DomainEntity", Version = "1.0")]

namespace PetClinic.Domain.Entities
{
    [DefaultIntentManaged(Mode.Fully, Targets = Targets.Methods, Body = Mode.Ignore, AccessModifiers = AccessModifiers.Public)]
    public class PetType
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}