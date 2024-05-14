namespace FamilyHubs.ServiceDirectory.Shared;

using FamilyHubs.ServiceDirectory.Shared.Enums;

public class ServiceTypeDto
{
    public ServiceType Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
}
