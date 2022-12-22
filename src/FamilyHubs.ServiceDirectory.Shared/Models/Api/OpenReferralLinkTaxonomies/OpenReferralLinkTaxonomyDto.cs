using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralTaxonomys;

namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralLinkTaxonomies
{
    public class OpenReferralLinkTaxonomyDto : IOpenReferralLinkTaxonomyDto
    {
        public OpenReferralLinkTaxonomyDto(string id, string type, string linkId, OpenReferralTaxonomyDto taxonomy)
        {
            Id = id;
            Type = type;
            LinkId = linkId;
            Taxonomy = taxonomy;
        }

        public string Id { get; set; }
        public string Type { get; init; }
        public string LinkId { get; set; }
        public OpenReferralTaxonomyDto? Taxonomy { get; init; }
    }
}
