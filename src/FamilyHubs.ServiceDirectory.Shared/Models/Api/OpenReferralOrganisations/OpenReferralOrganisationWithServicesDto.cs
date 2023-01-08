using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralLinkContacts;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralServices;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OrganisationType;

namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralOrganisations;

public record OpenReferralOrganisationWithServicesDto : IOpenReferralOrganisationWithServicesDto
{
    public OpenReferralOrganisationWithServicesDto() { }
    public OpenReferralOrganisationWithServicesDto(
        string id, ICollection<OpenReferralLinkContactDto> linkContacts, OrganisationTypeDto organisationType = default!,
        string? name = default!,
        string? description = default!,
        string? logo = default!,
        string? uri = default!,
        string? url = default!,
        ICollection<OpenReferralServiceDto>? services = default!)
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
    public string? AdministractiveDistrictCode { get; set; }
    public virtual ICollection<OpenReferralServiceDto>? Services { get; set; } = default!;
    public ICollection<OpenReferralLinkContactDto>? LinkContacts { get; set; }
}

