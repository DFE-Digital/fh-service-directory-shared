using FamilyHubs.ServiceDirectory.Shared.Enums;

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record TaxonomyDto
{
    public TaxonomyDto() { }
    public TaxonomyDto(string id, string name, TaxonomyType taxonomyType, string? parent)
    {
        Id = id;
        Name = name;
        TaxonomyType = taxonomyType;
        Parent = parent;
    }

    public string Id { get; set; } = default!;
    public string Name { get; set; } = default!;
    public TaxonomyType TaxonomyType { get; set; }
    public string? Parent { get; set; }
}
