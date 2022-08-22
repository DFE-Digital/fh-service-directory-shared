using FamilyHubs.ServiceDirectory.Shared.Entities;

namespace FamilyHubs.ServiceDirectory.Shared.Interfaces.Entities
{
    public interface IOpenReferralLocation
    {
        ICollection<Accessibility_For_Disabilities>? Accessibility_for_disabilities { get; init; }
        string? Description { get; init; }
        double Latitude { get; init; }
        double Longitude { get; init; }
        string Name { get; init; }
        ICollection<OpenReferralPhysical_Address>? Physical_addresses { get; init; }
    }
}