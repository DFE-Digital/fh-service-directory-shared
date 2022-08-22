using FamilyHubs.ServiceDirectory.Shared.Enums;
using FamilyHubs.ServiceDirectory.Shared.Interfaces.RecordEntities;

namespace FamilyHubs.ServiceDirectory.Shared.RecordEntities;

public record OpenReferralServiceDeliveryRecord : IOpenReferralServiceDeliveryRecord
{
    private OpenReferralServiceDeliveryRecord() { }
    public OpenReferralServiceDeliveryRecord(string id, ServiceDelivery serviceDelivery)
    {
        Id = id;
        ServiceDelivery = serviceDelivery;
    }

    public string Id { get; init; } = default!;
    public ServiceDelivery ServiceDelivery { get; init; }
}
