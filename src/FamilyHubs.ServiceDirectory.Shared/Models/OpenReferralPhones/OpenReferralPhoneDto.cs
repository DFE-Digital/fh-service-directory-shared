namespace FamilyHubs.ServiceDirectory.Shared.Models.OpenReferralPhone;

public class OpenReferralPhoneDto : IOpenReferralPhoneDto
{
    private OpenReferralPhoneDto() { }
    public OpenReferralPhoneDto(string id, string number)
    {
        Id = id;
        Number = number;
    }

    public string Id { get; init; } = default!;
    public string Number { get; init; } = default!;
}
