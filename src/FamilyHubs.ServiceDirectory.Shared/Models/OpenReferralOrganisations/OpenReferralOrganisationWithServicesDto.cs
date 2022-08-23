using FamilyHubs.ServiceDirectory.Shared.Models.OpenReferralService;

namespace FamilyHubs.ServiceDirectory.Shared.Models.OpenReferralOrganisation;

public record OpenReferralOrganisationWithServicesDto : IOpenReferralOrganisationWithServicesDto 
{
    private OpenReferralOrganisationWithServicesDto()
    {

    }
    public OpenReferralOrganisationWithServicesDto(
        string id,
        string? name,
        string? description,
        string? logo,
        string? uri,
        string? url,
        ICollection<IOpenReferralServiceDto>? services)
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

    public virtual ICollection<IOpenReferralServiceDto>? Services { get; set; } = default!;

}

