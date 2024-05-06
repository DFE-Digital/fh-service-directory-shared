using FamilyHubs.ServiceDirectory.Shared.Enums;

namespace FamilyHubs.ServiceDirectory.Shared.Dto.Metrics;

public class EventDto
{
    public ServiceDirectorySearchEventType? Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
}