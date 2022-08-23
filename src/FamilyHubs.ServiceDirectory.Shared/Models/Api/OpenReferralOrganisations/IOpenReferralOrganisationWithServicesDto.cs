using FamilyHubs.ServiceDirectory.Shared.Models.OpenReferralService;

namespace FamilyHubs.ServiceDirectory.Shared.Models.OpenReferralOrganisation;

public interface IOpenReferralOrganisationWithServicesDto
{
    string? Description { get; init; }
    string Id { get; init; }
    string? Logo { get; init; }
    string? Name { get; init; }
    ICollection<IOpenReferralServiceDto>? Services { get; set; }
    string? Uri { get; init; }
    string? Url { get; init; }

    bool Equals(object? obj);
    bool Equals(OpenReferralOrganisationWithServicesDto? other);
    int GetHashCode();
    string ToString();
}