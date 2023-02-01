namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record TaxonomyDto
{
    public TaxonomyDto() { }
    public TaxonomyDto(string id, string name, string? vocabulary, string? parent)
    {
        Id = id;
        Name = name;
        Vocabulary = vocabulary;
        Parent = parent;
    }

    public string Id { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string? Vocabulary { get; set; }
    public string? Parent { get; set; }
}
