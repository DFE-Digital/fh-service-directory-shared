namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record OrganisationExDto : OrganisationDto
{
    private OrganisationExDto() { }
    public OrganisationExDto(string id = default!,
        OrganisationTypeDto organisationType = default!,
        string name = default!,
        string? description = default!,
        string? logo = default!,
        string? uri = default!,
        string? url = default!,
        string? email = default!,
        string? contactName = default!,
        string? contactPhone = default!)
        : base(id, organisationType, name, description, logo, uri, url)
    {
        Email = email;
        ContactName = contactName;
        ContactPhone = contactPhone;
    }

    public string? Email { get; set; }
    public string? ContactName { get; set; }
    public string? ContactPhone { get; set; }
}
