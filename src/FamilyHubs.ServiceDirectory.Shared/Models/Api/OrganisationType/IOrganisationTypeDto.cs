namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.OrganisationType;

public interface IOrganisationTypeDto
{
    string? Description { get; set; }
    string Id { get; set; }
    string Name { get; set; }
}