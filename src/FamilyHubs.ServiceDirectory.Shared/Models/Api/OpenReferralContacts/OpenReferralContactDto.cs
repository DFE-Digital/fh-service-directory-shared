using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralPhones;

namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralContacts;

public record OpenReferralContactDto : IOpenReferralContactDto
{
    public OpenReferralContactDto() { }
    public OpenReferralContactDto(
        string  id,
        string? title,
        string  name,
        string?  telephone,
        string?  sms,
        string?  email,
        string?  url,
        ICollection<OpenReferralPhoneDto>? phones
    )
    {
        Id = id;
        Title = title;
        Name = name;
        Telephone= telephone;
        Sms = sms;
        Email = email;
        Url = url;
        Phones = phones;
    }
    public string Id { get; set; } = default!;
    public string? Title { get; init; } = default!;
    public string Name { get; init; } = default!;
    public string? Telephone { get; init; } = default!;
    public string? Sms { get; init; } = default!;    
    public string? Email { get; init; } = default!;
    public string? Url { get; init; } = default!;
    public virtual ICollection<OpenReferralPhoneDto>? Phones { get; init; }
}
