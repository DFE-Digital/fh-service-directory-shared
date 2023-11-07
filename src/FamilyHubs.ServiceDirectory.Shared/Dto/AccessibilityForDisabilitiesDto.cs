using FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record AccessibilityForDisabilitiesDto : LocationDtoBase<long>
{
    public string? Accessibility { get; set; }
}