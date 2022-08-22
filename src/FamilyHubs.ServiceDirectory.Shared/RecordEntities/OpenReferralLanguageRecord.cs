using FamilyHubs.ServiceDirectory.Shared.Interfaces.RecordEntities;

namespace FamilyHubs.ServiceDirectory.Shared.RecordEntities;

public record OpenReferralLanguageRecord : IOpenReferralLanguageRecord
{
    private OpenReferralLanguageRecord() { }
    public OpenReferralLanguageRecord(string id, string language)
    {
        Id = id;
        Language = language;
    }
    public string Id { get; set; } = default!;
    public string Language { get; init; } = default!;
}
