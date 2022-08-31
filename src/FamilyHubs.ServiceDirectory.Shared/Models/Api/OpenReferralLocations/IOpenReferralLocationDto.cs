using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralPhysicalAddresses;

namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralLocations;

public interface IOpenReferralLocationDto
{
    string? Description { get; init; }
    string Id { get; init; }
    double Latitude { get; init; }
    double Longitude { get; init; }
    string Name { get; init; }
    ICollection<OpenReferralPhysicalAddressDto>? Physical_addresses { get; init; }
}