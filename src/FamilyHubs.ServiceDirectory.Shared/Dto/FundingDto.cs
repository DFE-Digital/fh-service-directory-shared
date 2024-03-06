using FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record FundingDto : DtoBase
{
    public long ServiceId { get; set; }
    public string? Source { get; set; }
}
