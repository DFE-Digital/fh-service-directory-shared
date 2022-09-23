namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralOrganisations;

public record OpenReferralOrganisationExDto : OpenReferralOrganisationDto
{
    private OpenReferralOrganisationExDto() { }
    public OpenReferralOrganisationExDto(string id = default!,
        string organisationTypeId = default!,
        string name = default!,
        string? description = default!,
        string? logo = default!,
        string? uri = default!,
        string? url = default!,
        string? email = default!,
        string? contactName = default!,
        string? contactPhone = default!)
        : base(id, name, description, logo, uri, url)
    {
        Email = email;
        ContactName = contactName;
        ContactPhone = contactPhone;
        OrganisationTypeId = organisationTypeId;
    }

    public string? Email { get; set; } = default!;
    public string? ContactName { get; set; } = default!;
    public string? ContactPhone { get; set; } = default!;
    public string OrganisationTypeId { get; set; } = default!;
}
