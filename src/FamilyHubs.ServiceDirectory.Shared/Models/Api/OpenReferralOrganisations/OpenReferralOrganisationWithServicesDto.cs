using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralServices;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OrganisationType;

namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralOrganisations;

public record OpenReferralOrganisationWithServicesDto
{
    public OpenReferralOrganisationWithServicesDto() { }
    public OpenReferralOrganisationWithServicesDto(
        string id,
        OrganisationTypeDto organisationType = default!,
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
    }

    public OrganisationTypeDto OrganisationType { get; set; } = default!;
    public string Id { get; set; } = default!;
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Logo { get; set; }
    public string? Uri { get; set; }
    public string? Url { get; set; }
    public string? AdminAreaCode { get; set; }
    public ICollection<OpenReferralServiceDto>? Services { get; set; }

}

