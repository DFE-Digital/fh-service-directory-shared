namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record ServiceTaxonomyDto
{
    public ServiceTaxonomyDto() { }
    public ServiceTaxonomyDto(string id, TaxonomyDto? taxonomy)
    {
        Id = id;
        Taxonomy = taxonomy;
    }
    public string Id { get; set; } = default!;
    public TaxonomyDto? Taxonomy { get; set; }
}
