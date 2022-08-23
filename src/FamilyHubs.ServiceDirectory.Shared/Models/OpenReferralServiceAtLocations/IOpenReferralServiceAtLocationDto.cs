using FamilyHubs.ServiceDirectory.Shared.Models.OpenReferralLocation;

namespace FamilyHubs.ServiceDirectory.Shared.Models.OpenReferralServiceAtLocation;

public interface IOpenReferralServiceAtLocationDto
{
    string Id { get; set; }
    OpenReferralLocationDto Location { get; init; }

    bool Equals(object? obj);
    bool Equals(OpenReferralServiceAtLocationDto? other);
    int GetHashCode();
    string ToString();
}