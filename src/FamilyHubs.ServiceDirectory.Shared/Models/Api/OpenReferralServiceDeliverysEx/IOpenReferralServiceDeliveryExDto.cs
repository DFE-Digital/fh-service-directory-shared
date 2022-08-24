using FamilyHubs.ServiceDirectory.Shared.Enums;

namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralServiceDeliverysEx;

public interface IOpenReferralServiceDeliveryExDto
{
    string Id { get; init; }
    ServiceDelivery ServiceDelivery { get; init; }
}