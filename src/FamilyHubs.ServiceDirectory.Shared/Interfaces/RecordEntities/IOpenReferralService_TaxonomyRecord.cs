using FamilyHubs.ServiceDirectory.Shared.RecordEntities;

namespace FamilyHubs.ServiceDirectory.Shared.Interfaces.RecordEntities
{
    public interface IOpenReferralService_TaxonomyRecord
    {
        string Id { get; set; }
        OpenReferralTaxonomyRecord? Taxonomy { get; init; }

        bool Equals(object? obj);
        bool Equals(OpenReferralService_TaxonomyRecord? other);
        int GetHashCode();
        string ToString();
    }
}