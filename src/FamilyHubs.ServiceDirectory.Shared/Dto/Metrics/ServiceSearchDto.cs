using FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;
using FamilyHubs.ServiceDirectory.Shared.Enums;

namespace FamilyHubs.ServiceDirectory.Shared.Dto.Metrics;

public record ServiceSearchDto : DtoBase
{
    public required string SearchPostcode { get; set; }
    public byte SearchRadiusMiles { get; set; }
    public long? UserId { get; set; }
    public short? HttpResponseCode { get; set; }
    public DateTime RequestTimestamp { get; set; }
    public DateTime? ResponseTimestamp { get; set; }
    public string? CorrelationId { get; set; }

    public ServiceDirectorySearchEventType SearchTriggerEventId { get; set; }
    public EventDto? SearchTriggerEvent { get; set; }

    public ServiceType ServiceSearchTypeId { get; set; }
    public ServiceTypeDto? ServiceSearchType { get; set; }
    
    public IEnumerable<ServiceSearchResultDto> ServiceSearchResults { get; set; } = Enumerable.Empty<ServiceSearchResultDto>();
}
