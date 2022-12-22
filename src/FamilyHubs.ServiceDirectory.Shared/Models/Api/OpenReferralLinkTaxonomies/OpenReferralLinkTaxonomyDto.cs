using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralTaxonomys;

namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralLinkTaxonomies
{
    public class OpenReferralLinkTaxonomyDto : IOpenReferralLinkTaxonomyDto
    {
        public OpenReferralLinkTaxonomyDto(string id, string linkType, string linkId, OpenReferralTaxonomyDto taxonomy)
        {
            Id = id;
            LinkType = linkType;
            LinkId = linkId;
            Taxonomy = taxonomy;
        }

        public string Id { get; set; }
        public string LinkType { get; init; }
        public string LinkId { get; set; }
        public OpenReferralTaxonomyDto? Taxonomy { get; init; }
    }
}
