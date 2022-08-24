namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralOrganisations;

public record OpenReferralOrganisationDto : IOpenReferralOrganisationDto
{
    public OpenReferralOrganisationDto() { }
    public OpenReferralOrganisationDto(
        string id,
        string? name,
        string? description,
        string? logo,
        string? uri,
        string? url
    )
    {
        Id = id;
        Name = name;
        Description = description;
        Logo = logo;
        Uri = uri;
        Url = url;
    }

    public string Id { get; init; } = default!;
    public string? Name { get; init; }
    public string? Description { get; init; }
    public string? Logo { get; init; }
    public string? Uri { get; init; }
    public string? Url { get; init; }
}