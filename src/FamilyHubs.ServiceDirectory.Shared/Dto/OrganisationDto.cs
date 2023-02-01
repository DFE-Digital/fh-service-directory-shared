namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record OrganisationDto
{
    public OrganisationDto() { }
    public OrganisationDto(string id,
        OrganisationTypeDto organisationType,
        string name,
        string? description,
        string? logo,
        string? uri,
        string? url)
    {
        Id = id;
        OrganisationType = organisationType;
        Name = name;
        Description = description;
        Logo = logo;
        Uri = uri;
        Url = url;
    }

    public OrganisationTypeDto OrganisationType { get; set; } = default!;
    public string Id { get; set; } = default!;
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Logo { get; set; }
    public string? Uri { get; set; }
    public string? Url { get; set; }
    public string? AdminAreaCode { get; set; }
}