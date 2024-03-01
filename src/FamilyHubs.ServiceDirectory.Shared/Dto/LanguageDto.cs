using FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record LanguageDto : DtoBase
{
    public long ServiceId { get; set; }
    public required string Name { get; set; }
    public required string Code { get; set; }
    public string? Note { get; set; }
}
