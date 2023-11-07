using FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;
using FamilyHubs.ServiceDirectory.Shared.Enums;

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record EligibilityDto : ServiceDtoBase<long>
{
    public EligibilityType EligibilityType { get; set; }
    public required int MaximumAge { get; set; }
    public required int MinimumAge { get; set; }
}