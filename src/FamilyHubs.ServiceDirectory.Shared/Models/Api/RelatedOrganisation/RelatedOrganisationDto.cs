namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.RelatedOrganisation;

public class RelatedOrganisationDto
{
    private RelatedOrganisationDto() { }
    public RelatedOrganisationDto(string id, string parentOrganisationId, string organisationId)
    {
        Id = id;
        ParentOrganisationId = parentOrganisationId;
        OrganisationId = organisationId;
    }

    public string Id { get; set; } = default!;
    public string ParentOrganisationId { get; set; } = default!;
    public string OrganisationId { get; set; } = default!;
}
