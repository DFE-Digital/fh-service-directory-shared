using FamilyHubs.ServiceDirectory.Shared.Enums;

namespace FamilyHubs.ServiceDirectory.Shared.Dto.Metrics;

public class ServiceSearchDto
{
    public long? Id { get; set; }
    public ServiceDirectorySearchEventType? SearchTriggerEventId { get; set; }
    public EventDto? SearchTriggerEvent { get; set; }
    public required string ServiceSearchType { get; set; }
    public required string SearchPostcode { get; set; }
    public byte SearchRadiusMiles { get; set; }
    public long UserId { get; set; }
    public byte? HttpResponseCode { get; set; }
    public DateTime RequestTimestamp { get; set; }
    public DateTime? ResponseTimestamp { get; set; }
    public string? CorrelationId { get; set; }
    public IEnumerable<ServiceSearchResultDto> ServiceSearchResults { get; set; } = Enumerable.Empty<ServiceSearchResultDto>();
}
