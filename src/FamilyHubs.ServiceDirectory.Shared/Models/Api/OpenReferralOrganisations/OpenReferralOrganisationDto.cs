using FamilyHubs.ServiceDirectory.Shared.Models.Api.OrganisationType;

namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralOrganisations;

public record OpenReferralOrganisationDto : IOpenReferralOrganisationDto
{
    public OpenReferralOrganisationDto() { }
    public OpenReferralOrganisationDto(
        string id,
        OrganisationTypeDto organisationType,
        string adminDistrict = default!,
        string name = default!,
        string? description = default!,
        string? logo = default!,
        string? uri = default!,
        string? url = default!
    )
    {
        Id = id;
        OrganisationType = organisationType;
        AdminDistrict = adminDistrict;
        Name = name;
        Description = description;
        Logo = logo;
        Uri = uri;
        Url = url;
    }

    public OrganisationTypeDto OrganisationType { get; set; } = default!;
    public string AdminDistrict { get; set; } = string.Empty;
    public string Id { get; init; } = default!;
    public string? Name { get; init; }
    public string? Description { get; init; }
    public string? Logo { get; init; }
    public string? Uri { get; init; }
    public string? Url { get; init; }
}