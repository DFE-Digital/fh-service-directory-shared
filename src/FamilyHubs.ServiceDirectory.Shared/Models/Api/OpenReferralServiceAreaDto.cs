namespace FamilyHubs.ServiceDirectory.Shared.Models.Api;

public record OpenReferralServiceAreaDto
{
    public OpenReferralServiceAreaDto() { }
    public OpenReferralServiceAreaDto(
        string id,
        string service_area,
        string? extent, string? uri
    )
    {
        Id = id;
        Service_area = service_area;
        Extent = extent;
        Uri = uri;
    }
    public string Id { get; init; } = default!;
    public string Service_area { get; init; } = default!;
    public string? Extent { get; init; }
    public string? Uri { get; init; }
}
