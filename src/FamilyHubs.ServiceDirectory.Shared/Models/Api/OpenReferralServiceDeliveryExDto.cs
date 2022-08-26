﻿using FamilyHubs.ServiceDirectory.Shared.Enums;

namespace FamilyHubs.ServiceDirectory.Shared.Models.Api;

public record OpenReferralServiceDeliveryExDto
{
    public OpenReferralServiceDeliveryExDto() { }
    public OpenReferralServiceDeliveryExDto(string id, ServiceDelivery serviceDelivery)
    {
        Id = id;
        ServiceDeliveryEx = serviceDelivery;
    }

    public string Id { get; init; } = default!;
    public ServiceDelivery ServiceDeliveryEx { get; init; }
}
