namespace FamilyHubs.ServiceDirectory.Shared.Dto
{
    public class LinkTaxonomyDto
    {
        public LinkTaxonomyDto(string id, string linkType, string linkId, TaxonomyDto taxonomy)
        {
            Id = id;
            LinkType = linkType;
            LinkId = linkId;
            Taxonomy = taxonomy;
        }

        public string Id { get; set; }
        public string LinkType { get; init; }
        public string LinkId { get; set; }
        public TaxonomyDto? Taxonomy { get; init; }
    }
}
