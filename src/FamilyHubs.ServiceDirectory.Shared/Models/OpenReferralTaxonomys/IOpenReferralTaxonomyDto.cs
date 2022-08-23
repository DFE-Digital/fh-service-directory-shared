namespace FamilyHubs.ServiceDirectory.Shared.Models.OpenReferralTaxonomy;

public interface IOpenReferralTaxonomyDto
{
    string Id { get; init; }
    string Name { get; init; }
    string? Parent { get; init; }
    string? Vocabulary { get; init; }

    bool Equals(object? obj);
    bool Equals(OpenReferralTaxonomyDto? other);
    int GetHashCode();
    string ToString();
}