using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralServices;

namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralOrganisations;

public record OpenReferralOrganisationWithServicesDto : IOpenReferralOrganisationWithServicesDto
{
    public OpenReferralOrganisationWithServicesDto() { }
    public OpenReferralOrganisationWithServicesDto(
        string id,
        string? name,
        string? description,
        string? logo,
        string? uri,
        string? url,
        ICollection<OpenReferralServiceDto>? services)
    {
        Id = id;
        Name = name;
        Description = description;
        Logo = logo;
        Uri = uri;
        Url = url;
        Services = services;
    }

    public string Id { get; set; } = default!;
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Logo { get; set; }
    public string? Uri { get; set; }
    public string? Url { get; set; }

    public virtual ICollection<OpenReferralServiceDto>? Services { get; set; } = default!;

}

