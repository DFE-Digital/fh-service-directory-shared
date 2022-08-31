namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralLanguages;

public record OpenReferralLanguageDto : IOpenReferralLanguageDto
{
    public OpenReferralLanguageDto() { }
    public OpenReferralLanguageDto(string id, string language)
    {
        Id = id;
        Language = language;
    }
    public string Id { get; set; } = default!;
    public string Language { get; init; } = default!;
}
