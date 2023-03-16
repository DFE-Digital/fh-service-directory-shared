namespace FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;

public record ServiceDtoBase<TId> : DtoBase<TId>
{
#pragma warning disable CS8618
    public TId ServiceId { get; set; }
#pragma warning restore CS8618
}