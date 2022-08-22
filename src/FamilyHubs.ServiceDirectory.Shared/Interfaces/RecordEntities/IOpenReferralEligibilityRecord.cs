using FamilyHubs.ServiceDirectory.Shared.RecordEntities;

namespace FamilyHubs.ServiceDirectory.Shared.Interfaces.RecordEntities
{
    public interface IOpenReferralEligibilityRecord
    {
        string Eligibility { get; init; }
        string Id { get; init; }
        int Maximum_age { get; init; }
        int Minimum_age { get; init; }

        bool Equals(object? obj);
        bool Equals(OpenReferralEligibilityRecord? other);
        int GetHashCode();
        string ToString();
    }
}