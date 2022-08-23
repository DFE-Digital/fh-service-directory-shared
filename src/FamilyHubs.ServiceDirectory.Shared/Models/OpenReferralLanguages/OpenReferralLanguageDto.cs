namespace FamilyHubs.ServiceDirectory.Shared.Models.OpenReferralLanguage;

public record OpenReferralLanguageDto : IOpenReferralLanguageDto
{
    private OpenReferralLanguageDto() { }
    public OpenReferralLanguageDto(string id, string language)
    {
        Id = id;
        Language = language;
    }
    public string Id { get; set; } = default!;
    public string Language { get; init; } = default!;
}
