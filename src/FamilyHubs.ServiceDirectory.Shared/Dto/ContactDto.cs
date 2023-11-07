using FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;
#pragma warning disable CS8604

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record ContactDto : DtoBase
{
    public string? Title { get; set; }
    public string? Name { get; set; }
    public required string Telephone { get; set; }
    public string? TextPhone { get; set; }
    public string? Url { get; set; }
    public string? Email { get; set; }
    public long? ServiceId { get; set; }
    public long? LocationId { get; set; }
}