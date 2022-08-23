using FamilyHubs.ServiceDirectory.Shared.Models.OpenReferralTaxonomy;

namespace FamilyHubs.ServiceDirectory.Shared.Models.OpenReferralServiceTaxonomy;

public record OpenReferralServiceTaxonomyDto : IOpenReferralServiceTaxonomyDto
{
    private OpenReferralServiceTaxonomyDto() { }
    public OpenReferralServiceTaxonomyDto(string id, OpenReferralTaxonomyDto? taxonomy)
    {
        Id = id;
        Taxonomy = taxonomy;
    }
    public string Id { get; set; } = default!;
    public OpenReferralTaxonomyDto? Taxonomy { get; init; }
}
