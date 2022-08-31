namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralPhones;

public class OpenReferralPhoneDto : IOpenReferralPhoneDto
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
