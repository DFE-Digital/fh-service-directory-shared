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
    public string Id { get; set; } = default!;
    public string EligibilityDescription { get; set; } = default!;
    public int MaximumAge { get; set; }
    public int MinimumAge { get; set; }
}
