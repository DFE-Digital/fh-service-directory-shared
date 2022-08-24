using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralPhones;

namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralContacts;

public record OpenReferralContactDto : IOpenReferralContactDto
{
    public OpenReferralContactDto() { }
    public OpenReferralContactDto(
        string id,
        string title,
        string name,
        ICollection<IOpenReferralPhoneDto>? phones
    )
    {
        Id = id;
        Title = title;
        Name = name;
        Phones = phones;
    }
    public string Id { get; set; } = default!;
    public string Title { get; init; } = default!;
    public string Name { get; init; } = default!;
    public virtual ICollection<IOpenReferralPhoneDto>? Phones { get; init; }
}
