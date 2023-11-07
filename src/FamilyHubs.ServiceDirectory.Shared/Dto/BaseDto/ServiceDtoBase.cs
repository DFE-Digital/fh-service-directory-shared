namespace FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;

//todo: why the generic param?
public record ServiceDtoBase<TId> : DtoBase
{
    //todo: why do we have Id and ServiceId? can we just have Id?
#pragma warning disable CS8618
    public TId ServiceId { get; set; }
#pragma warning restore CS8618
}