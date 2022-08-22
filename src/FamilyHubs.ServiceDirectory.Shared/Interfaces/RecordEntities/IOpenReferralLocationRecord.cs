using FamilyHubs.ServiceDirectory.Shared.RecordEntities;

namespace FamilyHubs.ServiceDirectory.Shared.Interfaces.RecordEntities
{
    public interface IOpenReferralLocationRecord
    {
        string? Description { get; init; }
        string Id { get; init; }
        double Latitude { get; init; }
        double Longitude { get; init; }
        string Name { get; init; }
        ICollection<OpenReferralPhysical_AddressRecord>? Physical_addresses { get; init; }

        bool Equals(object? obj);
        bool Equals(OpenReferralLocationRecord? other);
        int GetHashCode();
        string ToString();
    }
}