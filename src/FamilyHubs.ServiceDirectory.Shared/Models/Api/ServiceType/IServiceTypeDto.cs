namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.ServiceType;

public interface IServiceTypeDto
{
    string? Description { get; set; }
    string Id { get; set; }
    string Name { get; set; }
}