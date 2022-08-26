namespace FamilyHubs.ServiceDirectory.Shared.Models.Api;

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
