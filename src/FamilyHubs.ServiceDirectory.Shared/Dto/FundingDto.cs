using FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;
#pragma warning disable CS8604

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record FundingDto : ServiceDtoBase<long>
{
    public string? Source { get; set; }
}
