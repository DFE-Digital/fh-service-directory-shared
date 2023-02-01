namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record FundingDto
{
    private FundingDto() { }
    public FundingDto(string id, string source)
    {
        Id = id;
        Source = source;
    }
    public string Id { get; set; } = default!;
    public string Source { get; set; } = default!;
}
