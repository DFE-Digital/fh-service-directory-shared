using FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record ServiceNameDto : DtoBase
{
    public required string Name { get; set; }
}