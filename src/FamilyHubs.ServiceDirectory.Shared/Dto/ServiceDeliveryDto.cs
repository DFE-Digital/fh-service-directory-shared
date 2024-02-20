using FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;
using FamilyHubs.ServiceDirectory.Shared.Enums;

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record ServiceDeliveryDto : ServiceDtoBase
{
    public AttendingType Name { get; set; }
}
