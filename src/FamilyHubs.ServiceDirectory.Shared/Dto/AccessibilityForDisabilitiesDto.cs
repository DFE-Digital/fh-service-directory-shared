using FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record AccessibilityForDisabilitiesDto : DtoBase
{
    public long LocationId { get; set; }
    public string? Accessibility { get; set; }
}