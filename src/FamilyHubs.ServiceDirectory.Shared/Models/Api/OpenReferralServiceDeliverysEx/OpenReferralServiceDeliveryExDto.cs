using FamilyHubs.ServiceDirectory.Shared.Enums;

namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralServiceDeliverysEx;

public record OpenReferralServiceDeliveryExDto

{
    public OpenReferralServiceDeliveryExDto() { }
    public OpenReferralServiceDeliveryExDto(string id, ServiceDelivery serviceDelivery)
    {
        Id = id;
        ServiceDelivery = serviceDelivery;
    }

    public string Id { get; init; } = default!;
    public ServiceDelivery ServiceDelivery { get; init; }
}
