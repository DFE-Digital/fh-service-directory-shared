namespace FamilyHubs.ServiceDirectory.Shared.Interfaces.RecordEntities;

public record OpenReferralPhoneRecord : IOpenReferralPhoneRecord
{
    private OpenReferralPhoneRecord() { }
    public OpenReferralPhoneRecord(string id, string number)
    {
        Id = id;
        Number = number;
    }

    public string Id { get; init; } = default!;
    public string Number { get; init; } = default!;
}
