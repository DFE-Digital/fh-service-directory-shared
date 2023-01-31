namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public class UICacheDto
{
    private UICacheDto() { }
    public UICacheDto(string id, string value)
    {
        Id = id;
        Value = value;
    }

    public string Id { get; set; } = default!;
    public string Value { get; set; } = default!;
}
