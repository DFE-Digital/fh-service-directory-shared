namespace FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;

public record LocationDtoBase<TId> : DtoBase<TId>
{
#pragma warning disable CS8618
    public TId LocationId { get; set; }
#pragma warning restore CS8618
}