using FamilyHubs.ServiceDirectory.Shared.Enums;

namespace FamilyHubs.ServiceDirectory.Shared.Models.OpenReferralServiceDeliveryEx;

public interface IOpenReferralServiceDeliveryExDto
{
    string Id { get; init; }
    ServiceDelivery ServiceDelivery { get; init; }

    bool Equals(object? obj);
    bool Equals(OpenReferralServiceDeliveryExDto? other);
    int GetHashCode();
    string ToString();
}