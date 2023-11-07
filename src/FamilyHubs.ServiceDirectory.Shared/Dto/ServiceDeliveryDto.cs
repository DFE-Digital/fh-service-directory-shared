using FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;
using FamilyHubs.ServiceDirectory.Shared.Enums;

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record ServiceDeliveryDto : ServiceDtoBase
{
    //todo: why is the delivery type property called Name?
    public ServiceDeliveryType Name { get; set; }
}
