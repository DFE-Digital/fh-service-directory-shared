using FamilyHubs.ServiceDirectory.Shared.RecordEntities;

namespace FamilyHubs.ServiceDirectory.Shared.Interfaces.RecordEntities
{
    public interface IOpenReferralTaxonomyRecord
    {
        string Id { get; init; }
        string Name { get; init; }
        string? Parent { get; init; }
        string? Vocabulary { get; init; }

        bool Equals(object? obj);
        bool Equals(OpenReferralTaxonomyRecord? other);
        int GetHashCode();
        string ToString();
    }
}