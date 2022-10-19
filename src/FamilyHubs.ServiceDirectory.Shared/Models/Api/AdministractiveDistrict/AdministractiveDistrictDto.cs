namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.AdministractiveDistrict;

public record AdministractiveDistrictDto : IAdministractiveDistrictDto
{
    public AdministractiveDistrictDto() { }
    public AdministractiveDistrictDto(
        string id,
        string code,
        string organisationId
    )
    {
        Id = id;
        Code = code;
        OrganisationId = organisationId;
    }
    public string Id { get; init; } = default!;
    public string Code { get; init; } = default!;
    public string OrganisationId { get; init; } = default!;
}
