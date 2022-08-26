namespace FamilyHubs.ServiceDirectory.Shared.Models.Api;

public record OpenReferralContactDto
{
    public OpenReferralContactDto() { }
    public OpenReferralContactDto(
        string id,
        string title,
        string name,
        ICollection<OpenReferralPhoneDto>? phones
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
    public virtual ICollection<OpenReferralPhoneDto>? Phones { get; init; }
}
