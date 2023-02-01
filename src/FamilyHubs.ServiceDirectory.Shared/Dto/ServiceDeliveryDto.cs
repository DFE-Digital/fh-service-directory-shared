using FamilyHubs.ServiceDirectory.Shared.Enums;

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record ServiceDeliveryDto

{
    public ServiceDeliveryDto() { }
    public ServiceDeliveryDto(string id, ServiceDeliveryType name)
    {
        Id = id;
        Name = name;
    }

    public string Id { get; set; } = default!;
    public ServiceDeliveryType Name { get; set; }
}
