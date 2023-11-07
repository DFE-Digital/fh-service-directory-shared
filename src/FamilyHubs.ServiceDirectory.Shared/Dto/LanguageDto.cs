using FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record LanguageDto : ServiceDtoBase
{
    public required string Name { get; set; }
}
