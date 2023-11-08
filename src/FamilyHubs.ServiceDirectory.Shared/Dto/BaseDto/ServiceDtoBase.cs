namespace FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;

public record ServiceDtoBase : DtoBase
{
    public long ServiceId { get; set; }
}