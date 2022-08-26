using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralServices;

namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralOrganisations;

public interface IOpenReferralOrganisationWithServicesDto
{
    string? Description { get; init; }
    string Id { get; init; }
    string? Logo { get; init; }
    string? Name { get; init; }
    ICollection<OpenReferralServiceDto>? Services { get; set; }
    string? Uri { get; init; }
    string? Url { get; init; }
}