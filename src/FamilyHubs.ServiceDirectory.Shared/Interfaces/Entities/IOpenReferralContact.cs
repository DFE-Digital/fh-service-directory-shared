using FamilyHubs.ServiceDirectory.Shared.Entities;

namespace FamilyHubs.ServiceDirectory.Shared.Interfaces.Entities
{
    public interface IOpenReferralContact
    {
        string Name { get; init; }
        ICollection<OpenReferralPhone>? Phones { get; init; }
        string Title { get; init; }
    }
}