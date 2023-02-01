namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record AccessibilityForDisabilitiesDto
{
    private AccessibilityForDisabilitiesDto() { }
    public AccessibilityForDisabilitiesDto(string id, string accessibility)
    {
        Id = id;
        Accessibility = accessibility;
    }
    public string Id { get; set; } = default!;
    public string Accessibility { get; set; } = default!;
}
