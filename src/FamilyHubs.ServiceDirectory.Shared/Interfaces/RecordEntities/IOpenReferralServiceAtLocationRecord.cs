using FamilyHubs.ServiceDirectory.Shared.RecordEntities;

namespace FamilyHubs.ServiceDirectory.Shared.Interfaces.RecordEntities
{
    public interface IOpenReferralServiceAtLocationRecord
    {
        string Id { get; set; }
        OpenReferralLocationRecord Location { get; init; }

        bool Equals(object? obj);
        bool Equals(OpenReferralServiceAtLocationRecord? other);
        int GetHashCode();
        string ToString();
    }
}