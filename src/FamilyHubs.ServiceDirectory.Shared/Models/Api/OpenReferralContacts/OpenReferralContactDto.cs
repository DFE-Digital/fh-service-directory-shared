namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralContacts;

public record OpenReferralContactDto
{
    public OpenReferralContactDto() { }
    public OpenReferralContactDto(
        string id,
        string? title,
        string name,
        string telephone,
        string textPhone
    )
    {
        Id = id;
        Title = title;
        Name = name;
        Telephone = telephone;
        TextPhone = textPhone;
    }
    public string Id { get; set; } = default!;
    public string? Title { get; init; }
    public string Name { get; init; } = default!;
    public string Telephone { get; init; } = default!;
    public string TextPhone { get; init; } = default!;
}
