using FamilyHubs.ServiceDirectory.Shared.Enums;

namespace FamilyHubs.ServiceDirectory.Shared.Dto.Metrics;

public record EventDto
{
    public ServiceDirectorySearchEventType Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
}