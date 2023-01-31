namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record ServiceAreaDto
{
    public ServiceAreaDto() { }
    public ServiceAreaDto(
        string id,
        string serviceAreaDescription,
        string? extent, string? uri
    )
    {
        Id = id;
        ServiceAreaDescription = serviceAreaDescription;
        Extent = extent;
        Uri = uri;
    }
    public string Id { get; init; } = default!;
    public string ServiceAreaDescription { get; init; } = default!;
    public string? Extent { get; init; }
    public string? Uri { get; init; }
}
