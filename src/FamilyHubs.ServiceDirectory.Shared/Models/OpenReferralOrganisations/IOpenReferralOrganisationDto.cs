namespace FamilyHubs.ServiceDirectory.Shared.Models.OpenReferralOrganisation;

public interface IOpenReferralOrganisationDto
{
    string? Description { get; init; }
    string Id { get; init; }
    string? Logo { get; init; }
    string? Name { get; init; }
    string? Uri { get; init; }
    string? Url { get; init; }

    bool Equals(object? obj);
    bool Equals(OpenReferralOrganisationDto? other);
    int GetHashCode();
    string ToString();
}