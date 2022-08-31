namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralOrganisations;

public interface IOpenReferralOrganisationDto
{
    string? Description { get; init; }
    string Id { get; init; }
    string? Logo { get; init; }
    string? Name { get; init; }
    string? Uri { get; init; }
    string? Url { get; init; }
}