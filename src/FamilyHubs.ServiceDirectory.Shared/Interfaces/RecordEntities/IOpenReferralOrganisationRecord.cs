using FamilyHubs.ServiceDirectory.Shared.RecordEntities;

namespace FamilyHubs.ServiceDirectory.Shared.Interfaces.RecordEntities
{
    public interface IOpenReferralOrganisationRecord
    {
        string? Description { get; init; }
        string Id { get; init; }
        string? Logo { get; init; }
        string? Name { get; init; }
        string? Uri { get; init; }
        string? Url { get; init; }

        bool Equals(object? obj);
        bool Equals(OpenReferralOrganisationRecord? other);
        int GetHashCode();
        string ToString();
    }
}