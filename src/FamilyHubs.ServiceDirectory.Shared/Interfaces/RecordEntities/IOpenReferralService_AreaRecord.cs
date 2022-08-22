using FamilyHubs.ServiceDirectory.Shared.RecordEntities;

namespace FamilyHubs.ServiceDirectory.Shared.Interfaces.RecordEntities
{
    public interface IOpenReferralService_AreaRecord
    {
        string? Extent { get; init; }
        string Id { get; init; }
        string Service_area { get; init; }
        string? Uri { get; init; }

        bool Equals(object? obj);
        bool Equals(OpenReferralService_AreaRecord? other);
        int GetHashCode();
        string ToString();
    }
}