namespace FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;

public record ServiceDtoBase : DtoBase
{
    //todo: why do we have Id and ServiceId? can we just have Id?
    public long ServiceId { get; set; }
}