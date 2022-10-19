using FamilyHubs.ServiceDirectory.Shared.Models.Api.OrganisationType;

namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralOrganisations;

public record OpenReferralOrganisationDto : IOpenReferralOrganisationDto
{
    public OpenReferralOrganisationDto() { }
    public OpenReferralOrganisationDto(
        string id,
        OrganisationTypeDto organisationType,
        string name = default!,
        string? description = default!,
        string? logo = default!,
        string? uri = default!,
        string? url = default!
    )
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
    public string? AdministractiveDistrictCode { get; set; }
}