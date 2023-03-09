// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable ClassNeverInstantiated.Global
namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record ReviewDto
{    
    public long Id { get; set; }
    public long? ServiceId { get; set; }
    public long? OrganisationId { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public DateTime Date { get; set; }
    public string? Score { get; set; }
    public string? Url { get; set; }
    public string? Widget { get; set; }
}