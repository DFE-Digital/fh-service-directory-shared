// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable ClassNeverInstantiated.Global
namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record LanguageDto
{
    public required long Id { get; set; }
    public required long ServiceId { get; set; }
    public required string Name { get; set; }
}
