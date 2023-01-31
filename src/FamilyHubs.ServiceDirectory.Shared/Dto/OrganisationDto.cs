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
    public string Id { get; init; } = default!;
    public string? Name { get; init; }
    public string? Description { get; init; }
    public string? Logo { get; init; }
    public string? Uri { get; init; }
    public string? Url { get; init; }
    public string? AdminAreaCode { get; set; }
}