namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public class OrganisationTypeDto
{
    private OrganisationTypeDto() { }
    public OrganisationTypeDto(string id, string name, string? description)
    {
        Id = id;
        Name = name;
        Description = description;
    }
    public string Id { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
}