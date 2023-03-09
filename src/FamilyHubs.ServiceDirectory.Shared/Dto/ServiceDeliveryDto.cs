// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable ClassNeverInstantiated.Global
using FamilyHubs.ServiceDirectory.Shared.Enums;

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record ServiceDeliveryDto
{
    public long Id { get; set; }
    public required long ServiceId { get; set; }
    public ServiceDeliveryType Name { get; set; }
}
