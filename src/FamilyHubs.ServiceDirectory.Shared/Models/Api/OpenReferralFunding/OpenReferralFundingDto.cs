namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralFunding;

public record OpenReferralFundingDto : IOpenReferralFundingDto
{
    private OpenReferralFundingDto() { }
    public OpenReferralFundingDto(string id, string source)
    {
        Id = id;
        Source = source;
    }
    public string Id { get; init; } = default!;
    public string Source { get; init; } = default!;
}
