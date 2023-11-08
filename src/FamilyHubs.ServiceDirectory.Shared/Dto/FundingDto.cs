using FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record FundingDto : ServiceDtoBase
{
    public string? Source { get; set; }
}
