using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralTaxonomys;

namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralServiceTaxonomys;

public record OpenReferralServiceTaxonomyDto
{
    public OpenReferralServiceTaxonomyDto() { }
    public OpenReferralServiceTaxonomyDto(string id, OpenReferralTaxonomyDto? taxonomy)
    {
        Id = id;
        Taxonomy = taxonomy;
    }
    public string Id { get; set; } = default!;
    public OpenReferralTaxonomyDto? Taxonomy { get; init; }
}
