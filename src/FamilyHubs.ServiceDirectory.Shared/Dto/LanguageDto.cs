namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record LanguageDto
{
    public LanguageDto() { }
    public LanguageDto(string id, string name)
    {
        Id = id;
        Name = name;
    }
    public string Id { get; set; } = default!;
    public string Name { get; set; } = default!;
}
