using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralLinkTaxonomies;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralPhysicalAddresses;

namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralLocations;

public record OpenReferralLocationDto
{
    public OpenReferralLocationDto() { }
    public OpenReferralLocationDto(
        string id,
        string name,
        string? description,
        double latitude,
        double longitude,
        ICollection<OpenReferralPhysicalAddressDto>? physical_addresses,
        ICollection<OpenReferralLinkTaxonomyDto>?  linkTaxonomies
    )
    {
        Id = id;
        Name = name;
        Description = description;
        Latitude = latitude;
        Longitude = longitude;
        Physical_addresses = physical_addresses;
        LinkTaxonomies = linkTaxonomies;
    }
    public string Id { get; init; } = default!;
    public string Name { get; init; } = default!;
    public string? Description { get; init; }
    public double Latitude { get; init; }
    public double Longitude { get; init; }
    public double? Distance { get; set; } = default(double?);
    public ICollection<OpenReferralPhysicalAddressDto>? Physical_addresses { get; init; }
    public ICollection<OpenReferralLinkTaxonomyDto>? LinkTaxonomies { get; set; }
}

