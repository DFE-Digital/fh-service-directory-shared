using FamilyHubs.ServiceDirectory.Shared.Interfaces.RecordEntities;

namespace FamilyHubs.ServiceDirectory.Shared.RecordEntities;

public record OpenReferralService_TaxonomyRecord : IOpenReferralService_TaxonomyRecord
{
    private OpenReferralService_TaxonomyRecord() { }
    public OpenReferralService_TaxonomyRecord(string id, OpenReferralTaxonomyRecord? taxonomy)
    {
        Id = id;
        Taxonomy = taxonomy;
    }
    public string Id { get; set; } = default!;
    public OpenReferralTaxonomyRecord? Taxonomy { get; init; }
}
