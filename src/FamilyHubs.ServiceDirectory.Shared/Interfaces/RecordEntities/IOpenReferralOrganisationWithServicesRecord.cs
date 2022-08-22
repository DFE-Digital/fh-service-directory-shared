using FamilyHubs.ServiceDirectory.Shared.RecordEntities;

namespace FamilyHubs.ServiceDirectory.Shared.Interfaces.RecordEntities
{
    public interface IOpenReferralOrganisationWithServicesRecord
    {
        string? Description { get; init; }
        string Id { get; init; }
        string? Logo { get; init; }
        string? Name { get; init; }
        ICollection<IOpenReferralServiceRecord>? Services { get; set; }
        string? Uri { get; init; }
        string? Url { get; init; }

        bool Equals(object? obj);
        bool Equals(OpenReferralOrganisationWithServicesRecord? other);
        int GetHashCode();
        string ToString();
    }
}