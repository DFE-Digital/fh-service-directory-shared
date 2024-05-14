namespace FamilyHubs.ServiceDirectory.Shared;

using FamilyHubs.ServiceDirectory.Shared.Enums;

public record ServiceTypeDto
{
    public ServiceType Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
}
