// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
using FamilyHubs.ServiceDirectory.Shared.Enums;

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record OrganisationDto
{
    public required OrganisationType OrganisationType { get; set; }
    public long Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required string AdminAreaCode { get; set; }
    public long? AssociatedOrganisationId { get; set; }
    public string? Logo { get; set; }
    public string? Uri { get; set; }
    public string? Url { get; set; }
}