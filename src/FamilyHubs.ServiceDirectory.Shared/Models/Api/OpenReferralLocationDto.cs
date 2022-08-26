namespace FamilyHubs.ServiceDirectory.Shared.Models.Api;

public record OpenReferralLocationDto
{
    public OpenReferralLocationDto() { }
    public OpenReferralLocationDto(
        string id,
        string name,
        string? description,
        double latitude,
        double longitude,
        ICollection<OpenReferralPhysicalAddressDto>? physical_addresses
    )
    {
        Id = id;
        Name = name;
        Description = description;
        Latitude = latitude;
        Longitude = longitude;
        Physical_addresses = physical_addresses;
    }
    public string Id { get; init; } = default!;
    public string Name { get; init; } = default!;
    public string? Description { get; init; }
    public double Latitude { get; init; }
    public double Longitude { get; init; }
    public ICollection<OpenReferralPhysicalAddressDto>? Physical_addresses { get; init; }
}

