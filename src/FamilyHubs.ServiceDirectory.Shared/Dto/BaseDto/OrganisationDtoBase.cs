namespace FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;

public record OrganisationDtoBase<TId> : DtoBase
{
#pragma warning disable CS8618
    public TId OrganisationId { get; set; }
#pragma warning restore CS8618
}