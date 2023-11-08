namespace FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;

//todo: these BaseDto's (apart from DtoBase) effectively add a foreign key, but it's confusing to use inheritance, which should be a is-a relationship
public record OrganisationDtoBase : DtoBase
{
    public long OrganisationId { get; set; }
}