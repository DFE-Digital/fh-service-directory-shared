using FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;
#pragma warning disable CS8604

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record ReviewDto : DtoBase
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public DateTime Date { get; set; }
    public string? Score { get; set; }
    public string? Url { get; set; }
    public string? Widget { get; set; }
    public long? ServiceId { get; set; }
    public long? OrganisationId { get; set; }
}