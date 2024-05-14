using FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;

namespace FamilyHubs.ServiceDirectory.Shared.Dto.Metrics;

public record ServiceSearchResultDto : DtoBase
{
    public long ServiceSearchesId { get; set; }
    public long ServiceId { get; set; }
}
