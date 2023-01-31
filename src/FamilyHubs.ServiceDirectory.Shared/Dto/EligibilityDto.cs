namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record EligibilityDto
{
    public EligibilityDto() { }
    public EligibilityDto(string id, string eligibilityDescription, int maximumAge, int minimumAge)
    {
        Id = id;
        EligibilityDescription = eligibilityDescription;
        MaximumAge = maximumAge;
        MinimumAge = minimumAge;
    }
    public string Id { get; init; } = default!;
    public string EligibilityDescription { get; init; } = default!;
    public int MaximumAge { get; init; }
    public int MinimumAge { get; init; }
}
