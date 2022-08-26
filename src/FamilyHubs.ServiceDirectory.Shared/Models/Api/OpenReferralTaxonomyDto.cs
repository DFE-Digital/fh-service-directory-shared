namespace FamilyHubs.ServiceDirectory.Shared.Models.Api;

public record OpenReferralTaxonomyDto
{
    public OpenReferralTaxonomyDto() { }
    public OpenReferralTaxonomyDto(string id, string name, string? vocabulary, string? parent)
    {
        Id = id;
        Name = name;
        Vocabulary = vocabulary;
        Parent = parent;
    }

    public string Id { get; init; } = default!;
    public string Name { get; init; } = default!;
    public string? Vocabulary { get; init; }
    public string? Parent { get; init; }
}
