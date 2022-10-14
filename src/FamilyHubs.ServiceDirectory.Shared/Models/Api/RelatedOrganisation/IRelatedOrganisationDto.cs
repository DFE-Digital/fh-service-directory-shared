namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.RelatedOrganisation;

public interface IRelatedOrganisationDto
{
    string Id { get; set; }
    string OrganisationId { get; set; }
    string ParentOrganisationId { get; set; }
}