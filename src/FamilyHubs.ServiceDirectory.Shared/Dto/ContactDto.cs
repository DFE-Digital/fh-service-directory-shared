namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record ContactDto
{
    public ContactDto() { }
    public ContactDto(
        string id,
        string? title,
        string name,
        string telephone,
        string textPhone,
        string? url, 
        string? email
    )
    {
        Id = id;
        Title = title;
        Name = name;
        Telephone = telephone;
        TextPhone = textPhone;
        Url = url;
        Email = email;
    }
    public string Id { get; set; } = default!;
    public string? Title { get; set; }
    public string Name { get; set; } = default!;
    public string Telephone { get; set; } = default!;
    public string TextPhone { get; set; } = default!;
    public string? Url { get; set; }
    public string? Email { get; set; }
}
