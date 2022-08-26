namespace FamilyHubs.ServiceDirectory.Shared.Models.Api;

public record UICache
{
    private UICache() { }

    public UICache(string id, string value) 
    { 
        Id = id;
        Value = value;
    }
    public string Id { get; set; } = default!;
    public string Value { get; init; } = default!;
}
