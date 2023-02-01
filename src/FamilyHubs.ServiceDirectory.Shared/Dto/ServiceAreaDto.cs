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
    public string Id { get; set; } = default!;
    public string ServiceAreaDescription { get; set; } = default!;
    public string? Extent { get; set; }
    public string? Uri { get; set; }
}
