using FamilyHubs.ServiceDirectory.Shared.Interfaces.RecordEntities;

namespace FamilyHubs.ServiceDirectory.Shared.RecordEntities;

public record OpenReferralService_AreaRecord : IOpenReferralService_AreaRecord
{
    private OpenReferralService_AreaRecord() { }
    public OpenReferralService_AreaRecord(string id, string service_area, string? extent, string? uri)
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
