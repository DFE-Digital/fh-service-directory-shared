namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record AdminAreaDto
{
    public AdminAreaDto() { }
    public AdminAreaDto(
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
