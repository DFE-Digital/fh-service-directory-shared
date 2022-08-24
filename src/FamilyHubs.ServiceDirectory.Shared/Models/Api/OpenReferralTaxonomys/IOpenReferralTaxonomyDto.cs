namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralTaxonomys;

public interface IOpenReferralTaxonomyDto
{
    string Id { get; init; }
    string Name { get; init; }
    string? Parent { get; init; }
    string? Vocabulary { get; init; }
}