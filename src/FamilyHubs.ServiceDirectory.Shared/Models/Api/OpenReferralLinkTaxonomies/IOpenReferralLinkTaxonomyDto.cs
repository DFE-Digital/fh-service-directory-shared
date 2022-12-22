using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralTaxonomys;

namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralLinkTaxonomies
{
    public interface IOpenReferralLinkTaxonomyDto
    {
        string Id { get; set; }
        string LinkType { get; init; }
        string LinkId { get; set; }
        OpenReferralTaxonomyDto? Taxonomy { get; init; }
    }
}
