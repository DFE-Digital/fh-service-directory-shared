namespace FamilyHubs.ServiceDirectory.Shared.Models.Api;

public class OpenReferralPhoneDto
{
    public OpenReferralPhoneDto() { }
    public OpenReferralPhoneDto(string id, string number)
    {
        Id = id;
        Number = number;
    }

    public string Id { get; init; } = default!;
    public string Number { get; init; } = default!;
}
