using FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;
using FamilyHubs.ServiceDirectory.Shared.Enums;

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record EligibilityDto : DtoBase
{
    public long ServiceId { get; set; }
    public EligibilityType? EligibilityType { get; set; }
    public required int MaximumAge { get; set; }
    public required int MinimumAge { get; set; }
}