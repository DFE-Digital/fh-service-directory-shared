// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable ClassNeverInstantiated.Global
namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record ContactDto
{
    public required long Id { get; set; }
    public string? Title { get; set; }
    public string? Name { get; set; }
    public required string Telephone { get; set; }
    public string? TextPhone { get; set; }
    public string? Url { get; set; }
    public string? Email { get; set; }
}