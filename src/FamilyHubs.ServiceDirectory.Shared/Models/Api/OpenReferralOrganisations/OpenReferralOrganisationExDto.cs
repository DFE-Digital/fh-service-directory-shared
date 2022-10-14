using FamilyHubs.ServiceDirectory.Shared.Models.Api.OrganisationType;

namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralOrganisations;

public record OpenReferralOrganisationExDto : OpenReferralOrganisationDto
{
    private OpenReferralOrganisationExDto() { }
    public OpenReferralOrganisationExDto(string id = default!,
        OrganisationTypeDto organisationType = default!,
        string adminDistrict = default!,
        string name = default!,
        string? description = default!,
        string? logo = default!,
        string? uri = default!,
        string? url = default!,
        string? email = default!,
        string? contactName = default!,
        string? contactPhone = default!)
        : base(id, organisationType, adminDistrict,  name, description, logo, uri, url)
    {
        Email = email;
        ContactName = contactName;
        ContactPhone = contactPhone;
    }

    public string? Email { get; set; } = default!;
    public string? ContactName { get; set; } = default!;
    public string? ContactPhone { get; set; } = default!;
}
