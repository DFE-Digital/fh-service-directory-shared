using FamilyHubs.ServiceDirectory.Shared.Models.OpenReferralPhysicalAddress;

namespace FamilyHubs.ServiceDirectory.Shared.Models.OpenReferralLocation;

public interface IOpenReferralLocationDto
{
    string? Description { get; init; }
    string Id { get; init; }
    double Latitude { get; init; }
    double Longitude { get; init; }
    string Name { get; init; }
    ICollection<OpenReferralPhysicalAddressDto>? Physical_addresses { get; init; }

    bool Equals(object? obj);
    bool Equals(OpenReferralLocationDto? other);
    int GetHashCode();
    string ToString();
}