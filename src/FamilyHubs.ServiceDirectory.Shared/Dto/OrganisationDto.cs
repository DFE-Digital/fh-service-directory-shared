using FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;
using FamilyHubs.ServiceDirectory.Shared.Enums;
#pragma warning disable CS8604
#pragma warning disable CS8607

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record OrganisationDto : DtoBase
{
    public required OrganisationType OrganisationType { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required string AdminAreaCode { get; set; }
    public long? AssociatedOrganisationId { get; set; }
    public string? Logo { get; set; }
    public string? Uri { get; set; }
    public string? Url { get; set; }
}