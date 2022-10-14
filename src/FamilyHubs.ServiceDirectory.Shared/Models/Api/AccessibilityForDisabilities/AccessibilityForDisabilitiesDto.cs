namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.AccessibilityForDisabilities;

public record AccessibilityForDisabilitiesDto : IAccessibilityForDisabilitiesDto
{
    private AccessibilityForDisabilitiesDto() { }
    public AccessibilityForDisabilitiesDto(string id, string accessibility)
    {
        Id = id;
        Accessibility = accessibility;
    }
    public string Id { get; init; } = default!;
    public string Accessibility { get; init; } = default!;
}
