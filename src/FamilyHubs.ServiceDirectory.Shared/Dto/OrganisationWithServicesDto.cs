namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record OrganisationWithServicesDto
{
    public OrganisationWithServicesDto()
    {
    }
    public OrganisationWithServicesDto(
        string id,
        OrganisationTypeDto organisationType = default!,
        string? name = default,
        string? description = default,
        string? logo = default,
        string? uri = default,
        string? url = default,
        ICollection<ServiceDto>? services = default,
        ICollection<LinkContactDto>? linkContacts = default)
    {
        Id = id;
        OrganisationType = organisationType;
        Name = name;
        Description = description;
        Logo = logo;
        Uri = uri;
        Url = url;
        Services = services;
        LinkContacts = linkContacts;
    }

    public OrganisationTypeDto OrganisationType { get; set; } = default!;
    public string Id { get; set; } = default!;
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Logo { get; set; }
    public string? Uri { get; set; }
    public string? Url { get; set; }
    public string? AdminAreaCode { get; set; }
    public ICollection<ServiceDto>? Services { get; set; }
    public ICollection<LinkContactDto>? LinkContacts { get; set; }
}

