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

    public string Id { get; init; } = default!;
    public string? Name { get; init; }
    public string? Description { get; init; }
    public string? Logo { get; init; }
    public string? Uri { get; init; }
    public string? Url { get; init; }

    public virtual ICollection<OpenReferralServiceDto>? Services { get; set; } = default!;

}

